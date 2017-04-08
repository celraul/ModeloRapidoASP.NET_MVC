using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.Persistencia.EF.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Cel.Modelo.Repositorio
{
    public class FeedRepository: RepositoryBase<Feed>, IfeedRepository
    {

        public override Feed GetById(int id)
        {
            return _modeloDbContext.Set<Feed>().Include(p => p.UsuarioCriacao)
                                               .SingleOrDefault(f => f.Id == id);
        }

        public override IEnumerable<Feed> GetALL()
        {
            return _modeloDbContext.Set<Feed>().Include(p => p.UsuarioCriacao).ToList();
        }
    
    }
}
