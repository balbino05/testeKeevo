// Startup.cs

using Microsoft.EntityFrameworkCore;

public class Startup
{

    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        // Configurações de serviço
        services.AddSingleton(Configuration);

        // Configuração do DbContext para uso com um banco de dados específico (por exemplo, PostgreSQL).
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
        
        // Outras configurações e serviços podem ser adicionados aqui.
    }

    // ...
}
