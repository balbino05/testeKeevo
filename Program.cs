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


app.MapGet("/task", () =>
{
    var task =  Enumerable.Range(1, 5).Select(index =>
        new task
        (
            Name : "teste",
            Description : "Task Description",
            Status : "Pending",
            CreatedAt : DateTime.Now,
            UpdatedAt : DateTime.Now

        ))
        .ToArray();
    return task;
})
.WithName("GetTask")
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
