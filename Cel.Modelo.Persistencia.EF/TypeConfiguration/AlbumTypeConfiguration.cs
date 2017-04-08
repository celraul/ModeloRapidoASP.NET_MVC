using Cel.Modelo.Comun.EF;
using Cel.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Persistencia.EF.TypeConfiguration
{
    internal class AlbumTypeConfiguration : CelEntityAbstractConfig<Album>
    {

        protected override void ConfigurarChavaEstrageira()
        {

        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id).IsRequired()
                               .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                               .HasColumnName("id");

            Property(p => p.Nome).IsRequired()
                                 .HasColumnName("nome")
                                 .HasMaxLength(200);

            Property(p => p.Ano).IsRequired()
                                 .HasColumnName("ano");

            Property(p => p.Observacoes).IsRequired()
                                 .HasColumnName("observacoes")
                                 .HasMaxLength(200);

            Property(p => p.Email).HasColumnName("email")
                                 .HasMaxLength(100);


                                 
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Albuns");
        }
    }
}
