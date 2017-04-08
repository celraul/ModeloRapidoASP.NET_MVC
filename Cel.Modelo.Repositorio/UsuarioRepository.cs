using Cel.Modelo.Dominio.Entidades;
using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.Persistencia.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cel.Modelo.Persistencia.EF.Context;

namespace Cel.Modelo.Repositorio
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IusuarioRepository
    {

        public UsuarioRepository()
        {
            base._modeloDbContext = new ModeloDbContext();
        }

        public List<Usuario> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        #region Ações

        public void SalvaUsuario(Usuario usuario)
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

        #endregion
    }
}
