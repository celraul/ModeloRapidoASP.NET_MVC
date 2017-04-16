using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Text;
using AutoMapper;
using System.Web.Security;
using Cel.Modelo.web.Models;
using Cel.Modelo.web.ViewModels;
using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.web.Identity;

namespace Cel.Modelo.web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public UserManager<ApplicationUser> UserManager { get; private set; }
        private readonly IusuarioRepository _usuarioRepository;

        public AccountController(IusuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(string ReturnUrl, [Bind(Exclude = "Ativo")]LoginViewModel loginViewModel)
        {

            if (ModelState.IsValid)
            {
                var userStore = new UserStore<IdentityUser>(new ModeloIdentityDbContext());
                var userManager = new UserManager<IdentityUser>(userStore);

                var usuario = userManager.Find(loginViewModel.UserName, loginViewModel.Password);

                
                if (usuario != null)
                {
                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identity = userManager.CreateIdentity(usuario, DefaultAuthenticationTypes.ApplicationCookie);
                    authManager.SignIn(new AuthenticationProperties()
                    {
                        IsPersistent = false,
                    }, identity);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("erro_identity", "Usuário ou senha invalidos");
                    return View(loginViewModel);
                }


                //var usuarios = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioRepository.GetALL());

                //loginViewModel.Ativo = true;
                //FormsAuthentication.SetAuthCookie(loginViewModel.UserName, false);
                //return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                return View(loginViewModel);
            }

        }

        public ActionResult LogOff()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            //FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Account");
        }

    }
}