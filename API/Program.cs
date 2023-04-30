using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); // Creates the Web Application Instance

// --------------------------------------------
// This is the services container. Add services to this container.
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt => {
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// --------------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers(); // Middleware

app.Run();
