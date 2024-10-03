using System.Collections.Generic;
using System.Reflection.Emit;
using HomePage.Models;
using Microsoft.EntityFrameworkCore;

namespace HomePage.Models
{
    public class StudentContext : DbContext
    {
        
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        
        public DbSet<Student> Student { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
           
            new Student { Id = 1, FirstName = "Tommy", LastName = "Wells", Grade = "A" },
            new Student { Id = 2, FirstName = "Eli", LastName = "Ashby", Grade = "B" },
            new Student { Id = 3, FirstName = "Emily", LastName = "Jones", Grade = "C" },
            new Student { Id = 4, FirstName = "Michael", LastName = "Harvey", Grade = "B+" },
            new Student { Id = 5, FirstName = "Amanda", LastName = "Christie", Grade = "A-" } );
            }
    }
}
