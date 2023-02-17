using UMBIT.API.EXEMPLO.Configurates;
using UMBIT.API.EXEMPLO.Servico;
using UMBIT.Core.Repositorio.ConfigUse;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var conexao = builder.Configuration.GetSection("ConnectionString").Value ?? "";
builder.Services.ConfigureServices(conexao);

builder.Services.AddScoped<IServicoDeGato, ServicoDeGato>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseConfigureMigrates();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
