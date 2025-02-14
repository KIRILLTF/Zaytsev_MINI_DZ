using Microsoft.Extensions.DependencyInjection;

namespace Zaytsev_MINI_DZ
{
    public static class Startup
    {
        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IZoo, Zoo>();
            services.AddSingleton<IVeterinaryClinic, VeterinaryClinic>();

            return services.BuildServiceProvider();
        }
    }
}
