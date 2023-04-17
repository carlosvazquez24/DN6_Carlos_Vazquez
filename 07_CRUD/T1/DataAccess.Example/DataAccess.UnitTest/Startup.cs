using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


    // Configure the HTTP request pipeline.




public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddDbContext<VehiclesDataContext>(options =>
            options.UseInMemoryDatabase("DataTest"));

        services.AddTransient<IQueriesExample, QueriesExample>();
        services.AddTransient<IColorsDataManager, ColorsDataManager>();
        services.AddTransient<IVehiclesDataManager, VehiclesDataManager>();

        services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);

        //Ignore the object refernce in the elements of the list
        services.AddControllers().AddNewtonsoftJson
            (x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

    }

    public void Configure(IApplicationBuilder app)
    {


        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseHttpsRedirection();

    }
}


