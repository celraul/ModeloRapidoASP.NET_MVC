using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.Persistencia.EF.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Cel.Modelo.Persistencia.EF.Context;
using System;
using System.Threading.Tasks;

namespace Cel.Modelo.Repositorio
{
    public class FeedRepository : RepositoryBase<Feed>, IfeedRepository
    {
        public FeedRepository()
        {
            base._modeloDbContext = new ModeloDbContext();
        }

        public override Feed GetById(int id)
        {
            return _modeloDbContext.Set<Feed>().Include(p => p.UsuarioCriacao)
                                               .SingleOrDefault(f => f.IdFeed == id);
        }

        public override IEnumerable<Feed> GetALL()
        {
            return _modeloDbContext.Set<Feed>().Include(p => p.UsuarioCriacao).ToList();
        }

        public void SalvaFeed(string texto)
        {
            var feed = new Feed()
            {
                Texto = texto,
                UsuarioCriacaoId = 1017,
                DataCriacao = DateTime.Now
                // carregar usuario conectado
            };

            base.Add(feed);
        }

        public async Task<IEnumerable<Feed>> ListAllAsync()
        {
            return base.GetALL().ToList();
        }
    }
}
