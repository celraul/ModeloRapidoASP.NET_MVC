using Cel.Modelo.Comun.EF;
using Cel.Modelo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Persistencia.EF.TypeConfiguration
{
    public class EmpresaTypeConfiguration : CelEntityAbstractConfig<Empresa>
    {

        protected override void ConfigurarChavaEstrageira()
        {

        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdEmpresa);
        }

        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdEmpresa).IsRequired()
                              .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                              .HasColumnName("id");

            Property(p => p.NomeFantasia).IsRequired()
                                   .HasColumnName("nome_fantasia")
                                   .HasMaxLength(500);

            Property(p => p.RazaoSocial).IsRequired()
                                  .HasColumnName("razao_social")
                                  .HasMaxLength(500);

            Property(p => p.Email).IsRequired()
                                  .HasColumnName("email")
                                  .HasMaxLength(500);

            Property(p => p.Cnpj).IsRequired()
                                 .HasColumnName("cnpj")
                                 .HasMaxLength(14);



        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("empresas");
        }
    }
}
