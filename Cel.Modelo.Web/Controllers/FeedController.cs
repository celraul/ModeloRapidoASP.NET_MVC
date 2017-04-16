using AutoMapper;
using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Enum;
using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cel.Modelo.web.Controllers
{
    public class FeedController : ControllerBasico
    {

        private readonly IfeedRepository _feedRepository;


        public FeedController(IfeedRepository feedRepository)
        {
            _feedRepository = feedRepository;
        }


        // GET: Feed
        public ActionResult Lista()
        {
            var feeds = Mapper.Map<IEnumerable<Feed>, IEnumerable<FeedViewModel>>(_feedRepository.GetALL());
            ShowToast();

            return View( new FeedListViewModel() { Feeds = feeds  } );
        }

        #region metodos

        [HttpPost]
        public ActionResult SalvaFeed(FeedListViewModel view)
        {
            if (ModelState.IsValid)
            {
                _feedRepository.SalvaFeed(view.TextoFeedNovo);
                _feedRepository.SaveChanges();

                SetToast(new Toast(TipoToast.Success, "Feed Salvo com sucesso!"));
                RedirectToAction("Lista");
            }
            else
                SetToast(new Toast(TipoToast.Info, "insira um texto"));

            return RedirectToAction("Lista");
        }

        #endregion
    }
}