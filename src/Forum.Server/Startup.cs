namespace Forum.Server;

public class Startup
{
    public Startup(IConfiguration configuration) => Configuration = configuration;

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        var presentationAssembly = typeof(Presentation.AssemblyReference).Assembly;

        services.AddControllers()
            .AddApplicationPart(presentationAssembly);

        services.AddRazorPages()
            .AddApplicationPart(presentationAssembly);
        services.AddServerSideBlazor();
    }
}