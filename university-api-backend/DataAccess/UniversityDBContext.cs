using Microsoft.EntityFrameworkCore;
using university_api_backend.DataModels;

namespace university_api_backend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> optinos): base(optinos)
        {

        }

        // TODO: Add DbSets (tables of our Data Base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
    }
}
