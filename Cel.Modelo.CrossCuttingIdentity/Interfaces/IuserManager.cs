using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.CrossCuttingIdentity.Interfaces
{
    public interface IuserManager
    {
        ApplicationUser FindUser(string userName, string password);
    }
}
