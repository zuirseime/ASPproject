using ASPproject.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASPproject.MainWeb;

public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();

        var connectionString = builder.Configuration.GetConnectionString("default");
        builder.Services.AddDbContext<ProjDBContext>(opt => opt.UseSqlServer(connectionString));

        var app = builder.Build();

        Database.Migrate(app);

        // Configure the HTTP request pipeline.

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
