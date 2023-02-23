using Microsoft.AspNetCore.Builder;
using Prototico.Core.API.Configurate.ApiConfigurate;
using Prototico.Core.API.Configurate.JsonWebToken;
using Prototico.Core.API.Configurate.Swagger;
using UMBIT.API.EXEMPLO.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration();
builder.Services.AddInjectionDependencyConfiguration(); 
builder.Services.AddUMBITSwaggerConfiguration();
builder.Services.AddUMBITServiceMySQL(builder.Configuration);
builder.Services.AddUMBITServiceJWT(builder.Configuration);


var app = builder.Build();

app.UseApiConfiguration(app.Environment);

app.Run();
