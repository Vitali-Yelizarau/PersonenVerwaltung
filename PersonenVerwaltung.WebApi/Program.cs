using Microsoft.EntityFrameworkCore;
using PersonenVerwaltung.DataAccess;
using PersonenVerwaltung.WebApi.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PersonenVerwaltungContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PersonenVerwaltung")));

builder.Services.AddControllers();
builder.Services.Configure<PersonListSettings>(builder.Configuration.GetSection("PersonListSettings"));
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
