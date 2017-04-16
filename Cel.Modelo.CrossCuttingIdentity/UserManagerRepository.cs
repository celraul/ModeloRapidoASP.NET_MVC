using Cel.Modelo.CrossCuttingIdentity.IdentityContext;
using Cel.Modelo.CrossCuttingIdentity.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.CrossCuttingIdentity
{
    public class UserManagerRepository : IuserManager
    {
        UserStore<ApplicationUser> _userStore;
        AplicationUserManager _userManager;

        public UserManagerRepository()
        {
            _userStore = new UserStore<ApplicationUser>(new ModeloIdentityDbContext());
            _userManager = new AplicationUserManager(_userStore);
        }

        public ApplicationUser FindUser(string userName , string password)
        {
            return _userManager.Find(userName, password);
        }
    }
}
