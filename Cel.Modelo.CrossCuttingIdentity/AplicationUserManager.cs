using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.CrossCuttingIdentity
{
    public class AplicationUserManager : UserManager<ApplicationUser>
    {
        public AplicationUserManager(IUserStore<ApplicationUser> store) : base(store)
        {

        }
    }
}
