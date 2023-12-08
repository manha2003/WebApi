
using Asp.Versioning;
using Asp.Versioning.Conventions;
using StudentWeb.Controllers.v1;
using StudentWeb.Controllers.v2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
  
    options.ReportApiVersions = true;
    options.ApiVersionReader = new UrlSegmentApiVersionReader();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
var versionSet = app.NewApiVersionSet()
                    .HasApiVersion(1, 0)
                    .HasApiVersion(2, 0)
                    .ReportApiVersions()
                    .Build();

app.MapGet("/students", (HttpContext context) => {

    var apiVersion = context.GetRequestedApiVersion();
    StudentsController controller = new StudentsController();
    return controller.students;

})
    .WithApiVersionSet(versionSet)
    .MapToApiVersion(1);


app.MapGet("/grades", (HttpContext context) => {

    var apiVersion = context.GetRequestedApiVersion();
    GradeController controller = new GradeController();
    return controller.grades;

})
    .WithApiVersionSet(versionSet)
    .MapToApiVersion(2);




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
