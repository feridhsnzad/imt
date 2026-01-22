using HealthCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthCenter.Data
{
    public class AppDbContex : DbContext
    {
        
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options) { }    
       
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
