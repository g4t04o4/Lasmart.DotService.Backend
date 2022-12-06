using Lasmart.DotService.Backend;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDotRepository, DotRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddDbContext<DotContext>(opt => opt.UseInMemoryDatabase("DotList"));

//builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// app.UseDefaultFiles();
// app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//should send the dots and comments from here when GET comes

//should delete a dot when POST comes

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/dotservice", () => "DotService");

app.Run();