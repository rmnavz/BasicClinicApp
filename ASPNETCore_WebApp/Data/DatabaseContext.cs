using Microsoft.EntityFrameworkCore;

namespace ASPNETCore_WebApp.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    }
}
