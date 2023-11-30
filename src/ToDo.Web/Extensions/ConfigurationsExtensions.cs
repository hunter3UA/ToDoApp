using Microsoft.EntityFrameworkCore;
using ToDo.Infrastructure.DbContexts;

namespace ToDo.Web.Extensions;

public static class ConfigurationsExtensions
{
    public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<ToDoDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoDb")));
        
        return builder;
    }

    public static WebApplication? UseMiddlewares(this WebApplication? app)
    {
        if (!app!.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        return app;
    }
}
