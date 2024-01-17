using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;


var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://*:" + Environment.GetEnvironmentVariable("PORT"));
var app = builder.Build();

app.MapGet("/", () => "Hello, World!");

app.Run();