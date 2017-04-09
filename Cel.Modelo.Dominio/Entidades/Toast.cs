using Cel.Modelo.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Dominio.Entidades
{
    public class Toast
    {
        public TipoToast Tipo { get; set; }
        public string Mensagem { get; set; }

        public Toast()
        {

        }

        public Toast(TipoToast tipo, string mensagem)
        {
            this.Tipo = tipo;
            this.Mensagem = mensagem;
        }

    }
}
