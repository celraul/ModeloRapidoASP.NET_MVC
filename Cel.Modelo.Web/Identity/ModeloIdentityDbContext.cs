using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cel.Modelo.web.Identity
{
    public class ModeloIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public ModeloIdentityDbContext()
            :base("ModeloDbContext")
        {
            
        }

    }
}