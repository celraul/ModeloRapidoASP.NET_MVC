using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Filtros;
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
        List<Usuario> BuscaPorFiltro(FiltroUsuarios filtro);
        void SalvarUsuario(Usuario usuario);
        void RemoverUsuario(Usuario usuario);

    }
}
