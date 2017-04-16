using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace Cel.Modelo.CrossCuttingIdentity
{
    public class ApplicationSignInManager : SignInManager<ApplicationUser, string>
    {
        public ApplicationSignInManager(UserManager<ApplicationUser, string> userManager, IAuthenticationManager authenticationManager) : base(userManager, authenticationManager)
        {

        }
    }
}
