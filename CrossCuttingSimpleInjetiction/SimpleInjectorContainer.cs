using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.Persistencia.EF.Repository;
using Cel.Modelo.Repositorio;
using SimpleInjector;
using System;
using System.Collections.Generic;
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

			container.Register<IusuarioRepository, UsuarioRepository>(Lifestyle.Singleton);
            container.Register<IempresaRepository, EmpresaRepository>(Lifestyle.Singleton);

            #endregion

            container.Verify();

            return container;

        }
    }
}
