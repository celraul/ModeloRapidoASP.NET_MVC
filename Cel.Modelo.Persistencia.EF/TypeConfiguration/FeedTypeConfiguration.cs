using Cel.Modelo.Comun.EF;
using Cel.Modelo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Persistencia.EF.TypeConfiguration
{
    public class FeedTypeConfiguration : CelEntityAbstractConfig<Feed>
    {


        protected override void ConfigurarChavaEstrageira()
        {
            HasRequired(p => p.UsuarioCriacao).WithMany(p => p.Feeds)
                                              .HasForeignKey(p => p.UsuarioCriacaoId);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdFeed);
        }

        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdFeed).IsRequired()
                               .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                               .HasColumnName("id");

            Property(p => p.NumeroVisualizacoes).HasColumnName("numero_visualizacoes");

            Property(p => p.Texto).IsRequired()
                                   .HasColumnName("texto")
                                   .HasMaxLength(500);

            Property(p => p.Visualizado).HasColumnName("visualizado");

            Property(p => p.UsuarioCriacaoId).HasColumnName("cod_usuario");

            Property(p => p.DataCriacao).HasColumnName("data_criacao");

        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("feeds");
        }
    }
}
