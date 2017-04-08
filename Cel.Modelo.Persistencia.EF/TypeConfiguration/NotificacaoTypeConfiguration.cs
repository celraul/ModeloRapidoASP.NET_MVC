using Cel.Modelo.Comun.EF;
using Cel.Modelo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Persistencia.EF.TypeConfiguration
{
    public class NotificacaoTypeConfiguration : CelEntityAbstractConfig<Notificacao>
    {

        protected override void ConfigurarChavaEstrageira()
        {
            HasRequired(p => p.UsuarioDestino).WithMany( p=> p.Notificacoes)
                                              .HasForeignKey(p => p.UsuarioDestinoId);


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

            Property(p => p.TipoNotificacao).HasColumnName("tipo_notificacao");

            Property(p => p.Texto).HasColumnName("texto")
                                  .IsRequired()
                                  .HasMaxLength(300);

            Property(p => p.UsuarioDestinoId).HasColumnName("cod_usuario");
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("notificacoes");
        }
    }
}
