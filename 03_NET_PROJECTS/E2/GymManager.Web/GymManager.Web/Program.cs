using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.Memberships;
using GymManager.ApplicationServices.Navigation;

var builder = WebApplication.CreateBuilder(args);

//Service that redirects the view with the controller
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddTransient<IMembersAppServices, MembersAppServices>();
builder.Services.AddTransient<IMenuAppService, MenuAppService>();
builder.Services.AddTransient<IMembershipAppService, MembershipAppService>();


var app = builder.Build();

// function that allow us to use static files
app.UseStaticFiles();

//app.MapGet("/File1", () => DateTime.Now.ToString());

app.MapControllerRoute( "default",  "{controller=home}/{action=Index}/{id?}");
app.MapControllerRoute("default", "{controller=Attendance}/{action=MemberIn}/{id?}");

app.Run();
