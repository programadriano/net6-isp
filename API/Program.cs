using API.Entities;
using API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddSingleton<IBaseLeituraRepository<Cidade>, CidadeRepository>();
//builder.Services.AddSingleton<IBaseLeituraRepository<Noticias>, NoticiasRepository>();
//builder.Services.AddSingleton<IBaseEscritaRepository<Noticias>, NoticiasRepository>();


builder.Services.AddSingleton<IBaseLeituraRepository<Cidade>,CidadeRepository>();
builder.Services.AddSingleton<IBaseEscritaRepository<Noticias>>(x => x.GetRequiredService<NoticiasRepository>());
builder.Services.AddSingleton<IBaseLeituraRepository<Noticias>>(x => x.GetRequiredService<NoticiasRepository>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
