using Microsoft.AspNetCore.Builder;
using Prototico.Core.API.Configurate.ApiConfigurate;
using Prototico.Core.API.Configurate.Swagger;
using UMBIT.API.EXEMPLO.Configurations;
using UMBIT.Prototico.Core.API.Configurate.IdentityConfigurate;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration();
builder.Services.AddInjectionDependencyConfiguration(); 
builder.Services.AddUMBITSwaggerConfiguration();
builder.Services.AddUMBITServiceMySQL(builder.Configuration);
builder.Services.AddUMBITIdentityConfiguration(builder.Configuration);


var app = builder.Build();

app.UseApiConfiguration(app.Environment);

app.Run();
