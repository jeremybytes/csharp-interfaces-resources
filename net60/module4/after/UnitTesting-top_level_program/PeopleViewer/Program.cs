using PersonReader.Factory;
using PersonReader.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options => options.ListenLocalhost(5000));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ReaderFactory>();
builder.Services.AddSingleton<IPersonReader>(
    s => s.GetService<ReaderFactory>()!.GetReader());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
