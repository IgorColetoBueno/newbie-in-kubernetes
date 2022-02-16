using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Kubernetes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddOcelot().AddKubernetes();

var app = builder.Build();

app.UseOcelot();

app.Run();
