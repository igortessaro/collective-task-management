using CollectiveTasksManagement.Infrastructure.CrossCutting.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Validators
_ = builder.Services.AddValidators();

_ = builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
_ = builder.Services.AddEndpointsApiExplorer();
_ = builder.Services.AddSwaggerGen();
_ = builder.Services.AddRouting(options => options.LowercaseUrls = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

_ = app.UseHttpsRedirection();
_ = app.UseAuthorization();
_ = app.MapControllers();

app.Run();
