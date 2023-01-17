using Microsoft.AspNetCore.Builder;
using System;
using Microsoft.Extensions.Hosting;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
//app.MapGet("/File1", () => DateTime.Now.ToString());
app.MapControllerRoute( "default",  "{controller=home}/{action=Index}/{id?}");

app.Run();
