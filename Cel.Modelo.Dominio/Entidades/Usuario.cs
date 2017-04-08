using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Dominio.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? DataCriacao { get; set; }
        public bool Ativo { get; set; }
        public  virtual List<Feed>  Feeds { get; set; }
        public virtual List<Notificacao> Notificacoes { get; set; }

        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }

    }
}
