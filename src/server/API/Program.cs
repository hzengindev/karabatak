using API;
using DataAccess;
using Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAPIDependencies();
builder.Services.AddDataAccessDependencies(builder.Configuration);
builder.Services.AddDomainDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
