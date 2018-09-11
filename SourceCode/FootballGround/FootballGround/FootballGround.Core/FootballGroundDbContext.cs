using FootballGround.Core.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGround.Core
{
    public class FootballGroundDbContext : IdentityDbContext<ApplicationUser>
    {
        public FootballGroundDbContext()
            : base("QuanLySanBongEntities", throwIfV1Schema: false)
        {
        }

        public static FootballGroundDbContext Create()
        {
            return new FootballGroundDbContext();
        }
    }
}
