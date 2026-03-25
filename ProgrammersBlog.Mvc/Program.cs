using ProgrammersBlog.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.LoadMyServices();

var app = builder.Build();

// Middleware Sýralamasý (Pipeline)
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles(); // CSS, JS dosyalarý için þart
app.UseRouting();    // Yönlendirmeyi baþlatýr

//app.UseAuthorization(); // Eðer yetkilendirme kullanacaksanýz Routing'den sonra gelmeli

// Area (Admin) rotasý her zaman genel rotadan ÖNCE yazýlmalýdýr
app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapDefaultControllerRoute(); // Varsayýlan (User tarafý) rotasý

app.Run();