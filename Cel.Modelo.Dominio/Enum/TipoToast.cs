using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Dominio.Enum
{
    public enum TipoToast
    {
        [Description("Sucesso")]
        Success = 1,
        [Description("Alerta")]
        Warning = 2,
        [Description("Erro")]
        Error = 3,
        [Description("Informação")]
        Info = 4
    }
}
