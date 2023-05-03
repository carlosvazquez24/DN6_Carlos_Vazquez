using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

string connectionString = builder.Configuration.GetConnectionString("Default");


builder.Services.AddDbContext<VehiclesDataContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddTransient<IQueriesExample, QueriesExample>();
builder.Services.AddTransient<IColorsDataManager, ColorsDataManager>();
builder.Services.AddTransient<IVehiclesDataManager, VehiclesDataManager>();

builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);

//Ignore the object refernce in the elements of the list
builder.Services.AddControllers().AddNewtonsoftJson
    (x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen( options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Test API", Version = "v1" });
});




var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseSwagger();

app.UseSwaggerUI(options =>
{

    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Test api");
});

app.Run();

