using AutoMapper;
using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Filtros;
using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public ActionResult ListaUsuarios(FormCollection form)
        {
            var nome = form["nome"];
            var userName = form["userName"];
            var filtro = new FiltroUsuarios() { Nome = nome, UserName = userName };
          
            var usuarios = _usuarioRepository.BuscaPorFiltro(filtro);
            ViewBag.Filtro = filtro;

            return View(Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(usuarios));
        }

        // GET: CadastroUsuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadastroUsuario/Create or Edit
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
                    var usuario = Mapper.Map<UsuarioViewModel, Usuario>(userViewModel);
                    _usuarioRepository.SalvarUsuario(usuario);

                    return RedirectToAction("ListaUsuarios");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Erro ao salvar Usuario.");

                    return View(userViewModel);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("erro ", ex.InnerException);
                //return View(userViewModel);
            }
        }

        // POST: CadastroUsuario/Delete/
        //[HttpPost]
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id.HasValue)
                {
                    var usuario = _usuarioRepository.GetById((int)id);
                    _usuarioRepository.RemoverUsuario(usuario);

                    return RedirectToAction("ListaUsuarios");
                }
                else
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            catch (Exception ex)
            {
                return View();
            }
        }

    }
}
