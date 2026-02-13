using Tasks.Aplication.UsersCase;
using Tasks.Aplication.UsersCase.Tasks;
using Tasks.Infrastructure_;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<CreatNewTask>();
builder.Services.AddScoped<GetAllTasks>();
builder.Services.AddScoped<GetTaskById>();
builder.Services.AddScoped<UpdateTask>();
builder.Services.AddSingleton<ITaskRepository, InMemory>();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
