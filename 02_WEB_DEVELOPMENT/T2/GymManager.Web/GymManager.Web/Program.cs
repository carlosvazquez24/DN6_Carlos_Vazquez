var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
app.MapGet("/File1", () => DateTime.Now.ToString());
app.Run();
