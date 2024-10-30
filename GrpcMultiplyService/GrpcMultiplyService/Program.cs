using GrpcMultiplyService.Services;

var builder = WebApplication.CreateBuilder(args);

// Force application to listen on a specific port (6060)
builder.WebHost.UseUrls("http://localhost:50052");

// Add gRPC services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<CalculatorServiceImpl>();
app.MapGet("/", () => "Hello! This is the gRPC Calculator Service running on http://localhost:6060");

app.Run();
