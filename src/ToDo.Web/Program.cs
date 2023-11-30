using ToDo.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.RegisterServices();

var app = builder.Build();
app.UseMiddlewares();

app.Run();
