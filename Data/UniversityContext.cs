using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class UniversityContext : DbContext

    {
        public DbSet<Student> student { get; set; }
        private static UniversityContext _instance = null;
        public static int count = 0;


        private UniversityContext(DbContextOptions options) : base(options)
        {
            count++;
        }

        public static UniversityContext Instantiate_University_Context()
        {
            if (_instance == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                optionsBuilder.UseSqlite(@"Data Source=..\database.db");
                _instance = new UniversityContext(optionsBuilder.Options);
            }
            return _instance;
        }


    }
}
