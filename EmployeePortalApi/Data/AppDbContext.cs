
using Microsoft.EntityFrameworkCore;
using EmployeePortalApi.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace EmployeePortalApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(table =>
            {
                table.HasKey(col => col.IdEmployee);
                table.Property(col => col.IdEmployee).UseIdentityColumn().ValueGeneratedOnAdd();
                table.Property(col => col.FullName).HasMaxLength(50);
                table.HasOne(col => col.ProfilesReference).WithMany(prof => prof.EmployeesReference).HasForeignKey(col => col.IdProfile);
                table.ToTable("Employee");
                
            });

            modelBuilder.Entity<Profile>(table =>
            {
                table.HasKey(col => col.IdProfile);
                table.Property(col => col.IdProfile).UseIdentityColumn().ValueGeneratedOnAdd();
                table.Property(col => col.Name).HasMaxLength(50);
                table.ToTable("Profile");
                table.HasData(
                    new Profile { IdProfile = 1, Name = "Front Developer" },
                    new Profile { IdProfile = 2, Name = "Back Developer" },
                    new Profile { IdProfile = 3, Name = "Analyst" }
                );
            });
        }


    }
}

