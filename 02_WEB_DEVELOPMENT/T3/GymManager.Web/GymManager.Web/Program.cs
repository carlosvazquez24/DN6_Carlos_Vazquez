var builder = WebApplication.CreateBuilder(args);

//Service that redirects the view with the controller
builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// function that allow us to use static files
app.UseStaticFiles();

//app.MapGet("/File1", () => DateTime.Now.ToString());

app.MapControllerRoute( "default",  "{controller=home}/{action=Index}/{id?}");

app.Run();
