using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.Persistencia.EF.Context;
using Cel.Modelo.Persistencia.EF.Repository;
using Cel.Modelo.Repositorio;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCuttingSimpleInjetiction
{
    public class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            #region Repository
            // container.Register<DbContext, ModeloDbContext>();

            container.Register<IusuarioRepository, UsuarioRepository>(Lifestyle.Singleton);
            container.Register<IempresaRepository, EmpresaRepository>(Lifestyle.Singleton);
            container.Register<IfeedRepository, FeedRepository>(Lifestyle.Singleton);
          //  container.Register<IuserManager, UserManagerRepository>(Lifestyle.Singleton);

            #endregion

            container.Verify();

            return container;

        }
    }
}
