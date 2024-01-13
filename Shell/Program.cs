namespace Shell;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        IConfigurationRoot confJsonFileTwo = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings2.json").Build();
        string? myStringToWeb = confJsonFileTwo.GetValue<string>("MyKey");

        var app = builder.Build();

        app.UseStaticFiles();
        app.UseRouting();
        app.MapControllers();

        app.Map("/", async context => 
        {
            //await context.Response.WriteAsync(app.Configuration.GetValue<string>("MyKey"));
            await context.Response.WriteAsync("\n" + myStringToWeb);
        });

        app.Run();
    }
}
