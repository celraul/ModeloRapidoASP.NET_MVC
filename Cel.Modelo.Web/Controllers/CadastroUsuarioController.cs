using AutoMapper;
using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Cel.Modelo.web.webControllers
{
    public class CadastroUsuarioController : Controller
    {
        private readonly IusuarioRepository _usuarioRepository;
        private readonly IempresaRepository _empresaRepository;

        public CadastroUsuarioController(IusuarioRepository usuarioRepository, IempresaRepository empresaRepository)
        {
            _usuarioRepository = usuarioRepository;
            _empresaRepository = empresaRepository;
        }

        // GET: CadastroUsuario
        public ActionResult ListaUsuarios()
        {
            var usuarios = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioRepository.GetALL());

            return View(usuarios);
        }

        // GET: CadastroUsuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadastroUsuario/Create
        public ActionResult Create(int? id)
        {
            List<EmpresaViewModel> Empresas = new List<EmpresaViewModel>();

            Empresas.Add(new EmpresaViewModel());
            Empresas.AddRange(Mapper.Map<IEnumerable<Empresa>, IEnumerable<EmpresaViewModel>>(_empresaRepository.GetALL()).ToList());
            SelectList selectEmpresas = new SelectList(Empresas, "IdEmpresa", "NomeFantasia");

            ViewBag.SelectEmpresas = selectEmpresas;

            if (id.HasValue)
            {
                var usuario = _usuarioRepository.GetById((int)id);
                if (usuario != null)
                {
                    var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);
                    return View(usuarioViewModel);
                }
                else
                    return HttpNotFound();
            }
            //else
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            return View();
        }

        // POST: CadastroUsuario/Create
        [HttpPost]
        public ActionResult Create(UsuarioViewModel userViewModel)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var user = Mapper.Map<Usuario>(userViewModel);  //this is wrong
                    var usuario = Mapper.Map<UsuarioViewModel, Usuario>(userViewModel);

                    if (userViewModel.IdUsuario != default(int))
                        _usuarioRepository.Update(usuario);
                    else
                        _usuarioRepository.Add(usuario);

                    return RedirectToAction("ListaUsuarios");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Erro ao salvar Usuario.");
                    return View(userViewModel);
                }

            }
            catch(Exception ex)
            {
                throw new Exception("erro ", ex.InnerException);
                //return View(userViewModel);
            }
        }

        // GET: CadastroUsuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadastroUsuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
