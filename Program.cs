//below is youtube link for better understanding the program.js file
//https://youtu.be/6qpQfo8WyaY?si=uWeeIunQeISdXjYR

using System.Text;
using FullStackProject.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// For a Razor Pages app:
builder.Services.AddRazorPages();
// If you also need classic MVC controllers + views, add this:
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IEmployeeReposiory, MockEmployeeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if(!app.Environment.IsDevelopment())
{
 app.UseExceptionHandler("/Home/Error");
 app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();// this midleware helps us to use stactic file in te application the static files are present in wwwrootfolder by default

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Map Razor Pages endpoints
app.MapRazorPages();

//Map MVC controller routes if you registered controllers + views
app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
