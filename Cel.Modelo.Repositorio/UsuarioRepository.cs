using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.Persistencia.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Repositorio
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IusuarioRepository
    {
        public List<Usuario> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
