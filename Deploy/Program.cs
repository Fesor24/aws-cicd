var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//- dotnet test --no-build --verbosity normal

app.Run();
