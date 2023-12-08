using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<APIDbContext>(options =>
{
    // Configure your DbContext options, such as connection string
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"));
});
/*
builder.Services.AddControllers(options =>
{
    // Add XML formatter and set it as the default
    options.OutputFormatters.RemoveType<SystemTextJsonOutputFormatter>();
    options.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
    options.FormatterMappings.SetMediaTypeMappingForFormat("xml", "application/xml");
    options.ReturnHttpNotAcceptable = true; // Optional: Respond with 406 if the client doesn't accept XML
}); */

builder.Services.AddControllersWithViews().AddXmlSerializerFormatters();

var app = builder.Build();

//Dependency Injection of DbContext Class


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
    context.Response.Headers.Add("User", "Hao Van");
    context.Response.Headers.Add("User2", "Dung Hoang");
    context.Response.Headers.Add("User3", "Khuong Nguyen");
    await next();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

