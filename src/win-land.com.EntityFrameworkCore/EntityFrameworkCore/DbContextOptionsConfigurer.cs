using Microsoft.EntityFrameworkCore;

namespace win-land.com.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<comDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for comDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
