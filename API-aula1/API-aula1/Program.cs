using API_aula1.Database;
using Microsoft.EntityFrameworkCore;
using API_aula1.Repositories;
using API_aula1.Repositories.Contratcs;
using AutoMapper;
using API_aula1.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MimicContext>(opt => {
    opt.UseSqlite("Data Source=Database\\Mimic.db");
});

//service.AddScoped<IPalavraRepository, PalavraRepository>(); tirar duvida com vinicius depois.
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new DTOMapperProfile());
});
//IMapper mapper = new config.CreateMapper(); tirar duvida com vinicius depois.
//services.AddSingleton(mapper); tirar duvida com vinicius depois.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStatusCodePages();
app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
       