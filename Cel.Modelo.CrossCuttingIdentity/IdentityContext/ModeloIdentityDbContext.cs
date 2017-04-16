using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.CrossCuttingIdentity.IdentityContext
{
    public class ModeloIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public ModeloIdentityDbContext()
            : base("ModeloDbContext")
        {

        }

    }
}
