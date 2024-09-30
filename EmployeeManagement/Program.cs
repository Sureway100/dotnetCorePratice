using EmployeeManagement.Models;

var builder = WebApplication.CreateBuilder(args);

//add servicesg
builder.Services.AddControllersWithViews();

//register dependency container
builder.Services.Add(new ServiceDescriptor(
    typeof(IEmployeeRepository),
    typeof(MockEmployeeRepository),
    ServiceLifetime.Transient));


var app = builder.Build();


if (app.Environment.IsDevelopment()) { app.UseDeveloperExceptionPage(); }


app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    // Use this to configure the default route like UseMvcWithDefaultRoute
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.MapControllers();




app.Run();
