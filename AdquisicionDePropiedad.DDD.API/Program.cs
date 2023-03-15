using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.CasosDeUso;
using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using AquisicionDePropiedad.DDD.Infraestructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("ProgrammerCS"),
                    b => b.MigrationsAssembly(typeof(DataBaseContext).Assembly.FullName)
));

builder.Services.AddScoped(typeof(IStoredEventRepository<>), typeof(StoredEventRepository<>));
builder.Services.AddScoped<lClienteCasoDeUso, ClienteCasoDeUso>();

builder.Services.AddScoped<lAgenteInmobiliarioCasoDeUso, AgenteInmobiliarioCasoDeUso>();
builder.Services.AddScoped(typeof(IStoredEventRepository<>), typeof(StoredEventRepository<>));


var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DataBaseContext>();
    context.Database.Migrate();
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
