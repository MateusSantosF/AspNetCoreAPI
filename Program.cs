using Learn.Business;
using Learn.Context;
using Learn.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependenciais

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

string conn = "Server=localhost;Database=LEARN;User=root;Password=40028922;";
builder.Services.AddDbContext<MySqlContext>( options => options.UseMySql(conn, 
                                            ServerVersion.AutoDetect(conn)));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
