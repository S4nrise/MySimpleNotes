using SimpleNotes.Configuration;
using SimpleNotes.Database;
using SimpleNotes.Endpoints;

var builder = WebApplication.CreateBuilder(args);

//Setup Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();
builder.Services.AddSimpleNotes(builder.Configuration);

var app = builder.Build();

//Map APIs
app.UseExceptionHandler();
app.UseAuthentication();
app.UseAuthorization();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseSimpleNotesEndpoints();

await DbInitializer.InitializeAsync(app);

//Start the server
app.Run();
