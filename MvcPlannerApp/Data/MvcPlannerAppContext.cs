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
