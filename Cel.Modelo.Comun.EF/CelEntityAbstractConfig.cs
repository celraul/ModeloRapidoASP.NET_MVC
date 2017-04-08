using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Comun.EF
{
    public abstract class CelEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade> where TEntidade : class
    {
        
        //tamplate method
        public CelEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChavaEstrageira();
        }

        protected abstract void ConfigurarChavaEstrageira();
        protected abstract void ConfigurarChavePrimaria();
        protected abstract void ConfigurarCamposTabela();
        protected abstract void ConfigurarNomeTabela();

    }
}
