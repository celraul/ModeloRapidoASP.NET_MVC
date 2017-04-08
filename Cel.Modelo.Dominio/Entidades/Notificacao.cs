using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cel.Modelo.Dominio.Enum;

namespace Cel.Modelo.Dominio.Entidades
{
    public class Notificacao
    {
        public int Id { get; set; }
        public TipoNotificacao TipoNotificacao { get; set; }
        public int UsuarioDestinoId { get; set; }
        public  virtual Usuario UsuarioDestino { get; set; }
        public string Texto { get; set; }
        
    }
}
