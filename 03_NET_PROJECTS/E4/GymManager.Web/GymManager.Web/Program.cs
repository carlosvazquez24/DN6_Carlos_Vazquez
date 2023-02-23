using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.MembershipsTypes;
using GymManager.ApplicationServices.Navigation;
using GymManager.DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);


//Service that redirects the view with the controller
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddTransient<IMembersAppServices, MembersAppServices>();
builder.Services.AddTransient<IMenuAppService, MenuAppService>();
builder.Services.AddTransient<IMembershipTypeAppService, MembershipTypeAppService>();

string connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<GymManagerContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<GymManagerContext>();

builder.Services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/LogIn");


//Serilog 
var logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).Enrich.FromLogContext().CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);


var app = builder.Build();

// function that allow us to use static files
app.UseStaticFiles();

//app.MapGet("/File1", () => DateTime.Now.ToString());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute( "default",  "{controller=home}/{action=Index}/{id?}");
app.MapControllerRoute("default", "{controller=Attendance}/{action=MemberIn}/{id?}");

app.Run();
