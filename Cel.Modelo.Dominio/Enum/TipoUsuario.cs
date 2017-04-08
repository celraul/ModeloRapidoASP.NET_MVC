using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Dominio.Enum
{
    public enum TipoUsuario
    {
        [Description("Adm")]
        Administrador = 1,

        [Description("Comum")]
        Comum = 2
    }
}
