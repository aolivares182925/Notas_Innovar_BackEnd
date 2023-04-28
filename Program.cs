using NotasAPI.Modules;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using NotasAPI.BusinessService;
using NotasAPI.DataServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

 builder.Services.AddDbContext<Context>(opt => 
        opt.UseSqlServer(builder.Configuration.GetConnectionString("connection_sql"))
    );

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


//llamada a la capa Business Service
builder.Services.AddTransient<AcademicDepartmentBusinessService>();

//llamada a la capa DataService
builder.Services.AddTransient<AcademicDepartmentDataService>();




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
