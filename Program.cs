using testeKeevo.Controllers;
using testeKeevo.Migrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("api/task", () =>
{
    return new task("Task 1", "Task 1 Description", "Open", DateTime.Now, DateTime.Now);
})
.WithName("GetTaskAll")
.WithOpenApi();

app.MapGet("api/task/{id}", (int id) =>
{
    return new getTask(id);

})
.WithName("GetById")
.WithOpenApi();

app.MapPost("/task", (task task) =>
{
    return Results.Created($"/task/{task.Name}", task);
})
.WithName("CreateTask")
.WithOpenApi();



app.Run();

record task( string Name, string Description, string Status, DateTime CreatedAt, DateTime UpdatedAt)
{
    public string Name { get; init; }
    public string Description { get; init; }
    public string Status { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
}

record getTask(int Id)
{
    public int Id { get; init; }
}
