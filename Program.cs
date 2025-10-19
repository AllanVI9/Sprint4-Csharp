using BibliotecaApi.Data; 
using Microsoft.EntityFrameworkCore;
using BibliotecaApi.Services;

var builder = WebApplication.CreateBuilder(args);


// Habilita CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var connString = Environment.GetEnvironmentVariable("SQLITE_CONN_STRING") ?? "Data Source=MinhaBiblioteca.db";

builder.Services.AddDbContext<BibliotecaContext>(options =>
    // options.UseSqlite("Data Source=biblioteca.db"));
    options.UseSqlite(connString));

builder.Services.AddControllers();
builder.Services.AddScoped<LivroService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Usar somente em teste, pois vai permitir tudo!
app.UseCors("AllowAll");

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
