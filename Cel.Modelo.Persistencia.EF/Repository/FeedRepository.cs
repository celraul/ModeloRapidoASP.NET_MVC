using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cel.Modelo.Persistencia.EF.Repository
{
    public class FeedRepository : RepositoryBase<Feed>, IfeedRepository
    {

        public override Feed GetById(int id)
        {
            return _modeloDbContext.Set<Feed>().Include(p => p.UsuarioCriacao)
                                               .SingleOrDefault(f => f.Id == id);
        }

        public override IEnumerable<Feed> GetALL()
        {
            return _modeloDbContext.Set<Feed>().Include(p => p.UsuarioCriacao)
                                               .ToList();
        }
    }
}
