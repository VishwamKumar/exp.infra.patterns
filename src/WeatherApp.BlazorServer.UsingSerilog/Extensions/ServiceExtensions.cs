namespace WeatherApp.BlazorServer.UsingSerilog.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureRazorServices(this WebApplicationBuilder builder)
    {
        builder.AddCustomLogging();       
        builder.Services.AddRazorComponents()
                        .AddInteractiveServerComponents();
    }
}