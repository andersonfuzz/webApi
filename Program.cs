var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
// extension methods
//PersonRoute.Routes(app);
app.Routes();
app.UseHttpsRedirection();
app.Run();

