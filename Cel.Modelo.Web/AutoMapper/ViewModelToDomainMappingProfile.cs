using AutoMapper;
using Cel.Modelo.Dominio;
using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagerMVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
            Mapper.CreateMap<AlbumViewModel, Album>();
            Mapper.CreateMap<EmpresaViewModel, Empresa>();
            Mapper.CreateMap<FeedViewModel, Feed>();

        }
    }
}