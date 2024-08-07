using FilamentManufacturer.Service.Services.Control;
using FilamentManufacturer.Service.Services.Parameters;
using FilamentManufacturer.Service.Services.Serial;
using Microsoft.Extensions.DependencyInjection;

namespace FilamentManufacturer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var service = new ServiceCollection();

            service.ConfigureDependenciesPages();
            service.ConfigureDependenciesServices();

            var serviceProvider = service.BuildServiceProvider();

            Application.Run(serviceProvider.GetRequiredService<ControlCenter>());
        }

        private static void ConfigureDependenciesPages(this IServiceCollection service)
        {
            service.AddSingleton<ControlCenter>();
            service.AddSingleton<ParametersPage>();
        }

        private static void ConfigureDependenciesServices(this IServiceCollection service)
        {
            service.AddSingleton<ISerialService, SerialService>(serviceProvider =>
            {
                var serial = new SerialService();
                Task.Run(serial.ConnectSerialPortAsync);
                return serial;
            });
            service.AddSingleton<IControlService, ControlService>();
            service.AddSingleton<IParametersService, ParametersService>(_ =>
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), AppDomain.CurrentDomain.FriendlyName);
                var filename = "Parameters";

                var parameters = new ParametersService(path, filename);

                return parameters;
            });
        }
    }
}