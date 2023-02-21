using UMBIT.API.EXEMPLO.Configurates;
using UMBIT.API.EXEMPLO.Servico;
using UMBIT.CORE.API.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServiceMySQL(builder.Configuration);

builder.Services.AddScoped<IServicoDeGato, ServicoDeGato>();

var app = builder.Build();

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
