using HealthCenter.Data;
using Microsoft.EntityFrameworkCore;

namespace HealthCenter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // Source - https://stackoverflow.com/a
            // Posted by George Piano Manikas, modified by community. See post 'Timeline' for change history
            // Retrieved 2026-01-22, License - CC BY-SA 4.0

            builder.Services.AddDbContext<AppDbContex>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

            });


            var app = builder.Build();

            
        

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "Admin",
                pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
