using SchoolActivity.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServicePresentation();

//builder.Configuration.AddJsonFile("Rules1.json", false, true);

builder.Services.AddControllers()
        .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);

var app = builder.Build();

// Global Error 
app.ConfigureGlobalException();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
