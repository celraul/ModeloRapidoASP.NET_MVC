using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.Persistencia.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cel.Modelo.Persistencia.EF.Context;
using Cel.Modelo.Dominio.Filtros;

namespace Cel.Modelo.Repositorio
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IusuarioRepository
    {

        public UsuarioRepository()
        {
            base._modeloDbContext = new ModeloDbContext();
        }

        #region Ações

        public void SalvarUsuario(Usuario usuario)
        {

            if (usuario != null)
            {
                if (usuario.IdUsuario != 0)
                {
                    var UsuBase = GetById(usuario.IdUsuario);
                    if (UsuBase != null)
                    {
                        UsuBase.Nome = usuario.Nome;
                        UsuBase.Password = usuario.Password;
                        UsuBase.UserName = usuario.UserName;
                        UsuBase.Email = usuario.Email;
                        UsuBase.Ativo = usuario.Ativo;
                        UsuBase.IdEmpresa = usuario.IdEmpresa;

                        SaveChanges();

                    }
                }
                else
                {
                    Add(usuario);
                    SaveChanges();
                }
            }


        }

        public void RemoverUsuario(Usuario usuario)
        {
            Remove(usuario);
            SaveChanges();
        }

        #endregion

        #region Listagens

        public List<Usuario> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> BuscaPorFiltro(FiltroUsuarios filtro)
        {
            if (!string.IsNullOrEmpty(filtro.Nome) || !string.IsNullOrEmpty(filtro.UserName))
                return GetList(RetornaFuncUsuario(filtro)).ToList();
            else
                return GetALL().ToList();
        }

        private Func<Usuario, bool> RetornaFuncUsuario(FiltroUsuarios filtro)
        {
            if (!string.IsNullOrEmpty(filtro.Nome) && !string.IsNullOrEmpty(filtro.Nome))
                return (usu => usu.Nome.Contains(filtro.Nome) && usu.UserName.Contains(filtro.UserName));

            if (!string.IsNullOrEmpty(filtro.Nome))
                return usu => usu.Nome.Contains(filtro.Nome);

            if (!string.IsNullOrEmpty(filtro.UserName))
                return usu => usu.UserName.Contains(filtro.UserName);

            return null;
        }

        #endregion

        #region validações

        #endregion

    }
}
