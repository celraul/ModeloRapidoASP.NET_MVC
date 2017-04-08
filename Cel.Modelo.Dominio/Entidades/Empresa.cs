using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Dominio.Entidades
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public  virtual List<Usuario> Usuarios { get; set; }

    }
}
