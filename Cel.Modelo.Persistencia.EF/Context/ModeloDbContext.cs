using Cel.Modelo.Dominio;
using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Persistencia.EF.TypeConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Persistencia.EF.Context
{
    public class ModeloDbContext : DbContext
    {
        public DbSet<Album> Abuns { get; set; }
        public DbSet<Usuario> Users { get; set; }
        public DbSet<Notificacao> Notificacoes { get; set; }
        public DbSet<Feed> Feeds { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        public ModeloDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
            modelBuilder.Configurations.Add(new UsuarioTypeConfiguration());
            modelBuilder.Configurations.Add(new FeedTypeConfiguration());
            modelBuilder.Configurations.Add(new NotificacaoTypeConfiguration());
            modelBuilder.Configurations.Add(new EmpresaTypeConfiguration());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(200));
        }
    }
}
