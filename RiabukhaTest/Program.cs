using RiabukhaTest;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using upswot.Domain.Extension;
using upswot.Services.Implementation;
using upswot.Services.Service_Interface;

var builder = WebApplication.CreateBuilder(args);


builder.Services.InitializeServices();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(CharacterExtension)));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
