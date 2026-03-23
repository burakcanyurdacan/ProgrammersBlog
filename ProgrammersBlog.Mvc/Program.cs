using ProgrammersBlog.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.LoadMyServices();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
