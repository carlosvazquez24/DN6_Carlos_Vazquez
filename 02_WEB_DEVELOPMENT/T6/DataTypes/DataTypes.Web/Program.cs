var builder = WebApplication.CreateBuilder(args);

//Redirects the requests to the controller
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); //With razorRuntimeCompilation allow us to watch the changes while it's compilating
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=" +
    "Home}/{action=Index}/{id?}");

app.Run();
