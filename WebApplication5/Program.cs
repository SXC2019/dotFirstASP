var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


//app.UseExceptionHandler("/Home/Error");
//app.UseStatusCodePagesWithReExecute("/Home/Error");
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllerRoute(name:"default",pattern:"{controller=Home}/{action=Index}/{id?}"));

app.Run();
