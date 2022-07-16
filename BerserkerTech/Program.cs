using BerserkerTech.Services.ComponentLogic;
using BerserkerTech.Services.ComponentLogic.Interfaces;
using BerserkerTech.Services.UserLogic;
using BerserkerTech.Services.UserLogic.SharedServices.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IRoleService, RoleService>();

//builder.Services.AddTransient<IComponentService, CpuService>();
//builder.Services.AddTransient<IComponentService, GpuService>();
//builder.Services.AddTransient<IComponentService, GpuService>();
//builder.Services.AddTransient<IComponentService, GpuService>();
//builder.Services.AddTransient<IComponentService, GpuService>();

builder.Services.AddSession(opt =>
{
    opt.IdleTimeout = TimeSpan.FromHours(5);
    opt.Cookie.HttpOnly = true;
    opt.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapRazorPages();

app.Run();
