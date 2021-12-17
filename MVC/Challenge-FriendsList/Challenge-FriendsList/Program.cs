using Challenge_FriendsList.Models;
using Challenge_FriendsList.Services;
using Microsoft.EntityFrameworkCore;
using Challenge_FriendsList.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionstring = "Server=DESKTOP-MRAQH42\\SQLEXPRESS;Database=Friends;Trusted_Connection=True;MultipleActiveResultSets=true";

builder.Services.AddDbContext<FriendContext>(options => options.UseSqlServer(connectionstring)); //service of data context
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IListOfFriends, ListOfFriends>(); //add butler to interact with database

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
