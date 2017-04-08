using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Persistencia.EF.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IusuarioRepository
    {

        public IEnumerable<Usuario> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

    }
}
