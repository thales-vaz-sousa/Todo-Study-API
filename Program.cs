using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

// configurando controllers
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(); // serviço podemos usar como serviço

// app.MapGet("/", () => "Hello World!");

var app = builder.Build();
app.MapControllers();

app.Run();