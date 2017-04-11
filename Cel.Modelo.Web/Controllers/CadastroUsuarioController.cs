using AutoMapper;
using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Filtros;
using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.web.Controllers;
using Cel.Modelo.web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;


namespace Cel.Modelo.web.webControllers
{
    [Authorize]
    public class CadastroUsuarioController : ControllerBasico
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
            ViewBag.SelectEmpresas = ListagemEmpresas();

            if (id.HasValue)
            {
                var usuario = _usuarioRepository.GetById((int)id);
                if (usuario != null)
                {
                    var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);
                    return View(usuarioViewModel);
                }
                else
                    throw new HttpException((int)HttpStatusCode.InternalServerError, "usuário não localizado");

            }

            ShowToast();

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

                    SetToast(new Toast(Dominio.Enum.TipoToast.Success, "Usuario criado com Sucesso."));

                    return RedirectToAction("ListaUsuarios");

                }
                else
                {
                    ViewBag.SelectEmpresas = ListagemEmpresas();
                    ModelState.AddModelError(string.Empty, "Erro ao salvar Usuario.");

                    ShowToast();

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

        private SelectList ListagemEmpresas()
        {
            List<EmpresaViewModel> Empresas = new List<EmpresaViewModel>();

            Empresas.Add(new EmpresaViewModel());
            Empresas.AddRange(Mapper.Map<IEnumerable<Empresa>, IEnumerable<EmpresaViewModel>>(_empresaRepository.GetALL()).ToList());
            SelectList selectEmpresas = new SelectList(Empresas, "IdEmpresa", "NomeFantasia");

            return selectEmpresas;

        }

        public ActionResult Modal()
        {
            return View();
        }

        public ActionResult AjaxPesquisarUsuario(string nome, string userName)
        {
            var usuarios = _usuarioRepository.BuscaPorFiltro(new FiltroUsuarios() { Nome = nome, UserName = userName }).ToList();
            if (usuarios != null && usuarios.Count() > 0)
            {
                var usuarioView = Mapper.Map<List<Usuario>, List<UsuarioViewModel>>(usuarios);
                return Json(usuarioView, JsonRequestBehavior.AllowGet);
            }
            else
                return Json(new { Error = true, TextError = "Não encontrado usuarios" }, JsonRequestBehavior.AllowGet);

        }

    }
}
