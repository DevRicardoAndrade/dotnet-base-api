using dotnet.Extensions;

var builder = WebApplication.CreateBuilder(args);

// BEGIN SERVICES
// Default services from .net core
builder.Services.ConfigureDefault();

// Get connection string for sql server from appsettings.json and set DbContext for EF
builder.Services.ConfigureConnectionString(builder.Configuration);

// Set Injections Dependency
builder.Services.ConfigureInjectionDependencys();
// END SERVICES

var app = builder.Build();

// BEGIN BUILD
// Default Builder Configuration from .net core
app.BuilderConfigurationDefault();
// END BUILD

app.Run();
