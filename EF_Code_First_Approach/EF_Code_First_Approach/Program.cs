using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EF_Code_First_Approach.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EF_Code_First_ApproachContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EF_Code_First_ApproachContext") ?? throw new InvalidOperationException("Connection string 'EF_Code_First_ApproachContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
