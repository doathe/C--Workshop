using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICategoryDal, CategoryDal>();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();

builder.Services.AddSingleton<IInstructorDal, InstructorDal>();
builder.Services.AddSingleton<IInstructorService, InstructorManager>();

builder.Services.AddSingleton<ICourseDal, CourseDal>();
builder.Services.AddSingleton<ICourseService, CourseManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
