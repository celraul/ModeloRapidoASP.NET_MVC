using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Dominio.Enum
{
    public enum TipoNotificacao
    {
        [Description("Unica")]
        Unica = 1 ,
        [Description("Geral")]
        Geral = 2
    }
}
