using FluentValidation;
using OzanAhmetDincerBlog.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IValidator<KullaniciFluentValidation>, KullaniciFluentValidation2>(); // FluentValidation kullanarak validasyon yapacaðýmýzý uygulamaya bildiriyoruz

builder.Services.AddSession(option => option.IdleTimeout = TimeSpan.FromMinutes(3)); // servis olarak session ý ekledik

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

app.UseSession(); // uygulamada session kullanmak istediðimizi belirttik

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
