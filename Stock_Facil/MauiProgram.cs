using Microsoft.Extensions.Logging;
using Stock_Facil.Services;
using Stock_Facil.Views;
using Stock_Facil.Views.Productos;

namespace Stock_Facil
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<AuthService>();

            builder.Services.AddSingleton<ProductoService>();

            builder.Services.AddSingleton<CategoriaService>();

            builder.Services.AddSingleton<ProveedorService>();

            builder.Services.AddTransient<LoginPage>();

            builder.Services.AddTransient<HomePage>();

            builder.Services.AddTransient<ProductoFormPage>();

            builder.Services.AddTransient<ProductoListPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
