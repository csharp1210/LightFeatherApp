using Microsoft.EntityFrameworkCore;
using LightFeatherProj.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<NotificationFormContext>(opt =>
    opt.UseInMemoryDatabase("NotificationFormDb"));
builder.Services.AddDbContext<SupervisorContext>(opt =>
    opt.UseInMemoryDatabase("SupervisorDb"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    //app.MapControllerRoute(
    //name: "default",
    //pattern: "{controller=NotificationForm}/{action=Index}");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
