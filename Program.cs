using Microsoft.EntityFrameworkCore;
using UsedCarsOnline.Data;
using UsedCarsOnline.Services;
using UsedCarsOnline.Services.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using UsedCarsOnline.StaticDetails;

namespace UsedCarsOnline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
               builder.Configuration.GetConnectionString("DefaultConnection")
               ));
            builder.Services.AddSingleton<IEmailSender, EmailSender>();
            builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddDefaultTokenProviders()
               .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddTransient<IAuctionRepository, AuctionRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication(); ;

            app.UseAuthorization();
            app.MapRazorPages();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}