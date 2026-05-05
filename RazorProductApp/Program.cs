var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.WebHost.UseUrls("http://localhost:5000");

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();

app.Run();