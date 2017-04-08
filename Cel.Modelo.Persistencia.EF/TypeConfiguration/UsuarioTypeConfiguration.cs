using Cel.Modelo.Comun.EF;
using Cel.Modelo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Persistencia.EF.TypeConfiguration
{
    public class UsuarioTypeConfiguration : CelEntityAbstractConfig<Usuario>
    {

        protected override void ConfigurarChavaEstrageira()
        {
            HasRequired(p => p.Empresa).WithMany(p => p.Usuarios)
                                       .HasForeignKey(p => p.IdEmpresa);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdUsuario);
        }

        protected override void ConfigurarCamposTabela()
        {

            Property(u => u.IdUsuario).IsRequired()
                              .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                              .HasColumnName("id");

            Property(u => u.Nome).IsRequired()
                                   .HasMaxLength(150)
                                   .HasColumnName("nome");

            Property(u => u.UserName).IsRequired()
                                     .HasMaxLength(100)
                                     .HasColumnName("username");

            Property(u => u.Email).HasMaxLength(200)
                                  .HasColumnName("email");

            Property(u => u.Password).IsRequired()
                                     .HasMaxLength(200)
                                     .HasColumnName("password");

            Property(u => u.IdEmpresa).HasColumnName("cod_empresa");
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("usuarios");
        }
    }
}
