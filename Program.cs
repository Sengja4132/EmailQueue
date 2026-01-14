using Mailing_Utility.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

internal class Program
{
    static async Task<int> Main(string[] args)
    {
        try
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .AddEnvironmentVariables()
                .Build();

            // DB configuration
            using var host = Host.CreateDefaultBuilder(args)
               .ConfigureServices((context, services) =>
               {
                   services.AddDbContext<ApplicationDbContext>(options =>
                       options.UseSqlServer(
                           context.Configuration.GetConnectionString("DefaultConnection")));

                   services.AddTransient<EmailService>();
               })
               .ConfigureLogging(logging =>
               {
                   logging.ClearProviders();
                   logging.AddConsole();
               })
               .Build();

            // Setup DI
            var services = new ServiceCollection();

            services.AddSingleton<IConfiguration>(configuration);
            services.AddLogging(config =>
            {
                config.AddConsole();
                config.SetMinimumLevel(LogLevel.Information);
            });

            // Register app services
            services.AddTransient<EmailService>();

            var provider = services.BuildServiceProvider();

            // Run job
            var logger = provider.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Task started at {Time}", DateTimeOffset.Now);

            var emailService = provider.GetRequiredService<EmailService>();

            using var scope = host.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            // 🔥 EF CORE USAGE HERE
            //var items = await db..ToListAsync();

            // await emailService.SendEmailAsync(...);

            logger.LogInformation("Task finished successfully at {Time}", DateTimeOffset.Now);
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
            return 1;
        }
    }
}
