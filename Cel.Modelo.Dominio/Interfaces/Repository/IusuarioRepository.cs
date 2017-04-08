using Cel.Modelo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Dominio.Interfaces.Repository
{
    public interface IusuarioRepository :IRepositoryBase<Usuario>
    {
        List<Usuario> BuscarPorNome(string nome);

        void SalvaUsuario(Usuario usuario);
    }
}
