using Microsoft.EntityFrameworkCore;

namespace CPAPP.Infastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}