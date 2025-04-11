using BusinessLogic.DependencyResolvers;
using DataAccess.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Configuration.GetConnectionString("DefaultConnection");

//Dependency Resolver DBContext
builder.Services.AddDbContext();
//Dependency Resolver Identity
builder.Services.AddIdentityServices();
//Dependency Resolver Scoped
builder.Services.AddScopedServices();



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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
