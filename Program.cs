using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseAuthentication();
app.UseRouting();
app.UseStaticFiles();

app.UseEndpoints(
    (endpoints) =>
    {
        endpoints.MapControllerRoute(
        name: "default",
        pattern: "{Controller=Home}/{Action=Index}"
        );
    }
    );
app.Run();
