
using System.Data.Entity;
using sb_admin_2.Web.Models;

namespace sb_admin_2.Web.DAL
{
    public class TaxiContext:DbContext
    {
        public DbSet<NewTaxi> NewTaxis { get; set; }
    }
}