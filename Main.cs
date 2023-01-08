var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var cApi = builder.Build();

// Configure the HTTP request pipeline.
if (cApi.Environment.IsDevelopment())
{
    cApi.UseSwagger();
    cApi.UseSwaggerUI();
}

cApi.UseHttpsRedirection();

cApi.UseAuthorization();

cApi.MapControllers();

cApi.Run();
