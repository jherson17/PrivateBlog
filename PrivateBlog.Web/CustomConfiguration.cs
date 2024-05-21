using Microsoft.EntityFrameworkCore;
using PrivateBlog.Web.Data;
using PrivateBlog.Web.Services;


namespace PrivateBlog.Web
{
    public static class CustomConfiguration
    {
        public static WebApplicationBuilder AddCustomBuilderConfiguration(this WebApplicationBuilder builder)
        {

            // Data Context
            builder.Services.AddDbContext<DataContext>(conf =>
            {
                conf.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"));// Configura Entity Framework Core para usar SQL Server como proveedor de base de datos y obtiene la cadena de conexión desde la configuración de la aplicación.
            });
            AddServices(builder);

            return builder;
        }

        private static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ISectionsService, SectionServices>();

            //helpers
        }
    }
}
