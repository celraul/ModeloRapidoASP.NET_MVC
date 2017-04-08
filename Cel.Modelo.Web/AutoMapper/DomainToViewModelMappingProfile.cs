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
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
            Mapper.CreateMap<Album, AlbumViewModel>();
            Mapper.CreateMap<Empresa, EmpresaViewModel>();
        }

    }
}