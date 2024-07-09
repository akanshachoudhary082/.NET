using Microsoft.EntityFrameworkCore;

using StudentInfoWeb.Models;
namespace StudentInfoWeb.Repositories
{
    public class CollectionContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstring = @"server = localhost;port=3306;user = root ; password=root123;database=students;";
            optionsBuilder.UseSqlServer(connstring);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Student_Id);
                entity.Property(e => e.Student_Name).IsRequired();
                entity.Property(e => e.Student_Email).IsRequired();
                entity.Property(e => e.Mobile_number).IsRequired();
                entity.Property(e => e.Student_Address).IsRequired();
                entity.Property(e => e.Admission_Date).IsRequired();
                entity.Property(e => e.Fees).IsRequired();
                entity.Property(e => e.Status).IsRequired();
            });
            modelBuilder.Entity<Student>().ToTable("students");
        }

    }
}