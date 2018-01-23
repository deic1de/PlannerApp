using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcPlannerApp.Models
{
    public class MvcPlannerAppContext : DbContext
    {
        public MvcPlannerAppContext (DbContextOptions<MvcPlannerAppContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPlannerApp.Models.Plans> Plans { get; set; }
    }
}
