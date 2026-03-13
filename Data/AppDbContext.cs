using Microsoft.EntiryFrameworkCore;

namespace TodoApi.Data
 {
    public class AppDbContext : AppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
            {
                
            }
    }

}