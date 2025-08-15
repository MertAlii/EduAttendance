using EduAttendance.WebAPI.Context;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlServer("Data Source=MERTALII\\SQLEXPRESS;database=EduAttendanceDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
});
builder.Services.AddControllers();
builder.Services.AddOpenApi();


var app = builder.Build();
app.MapOpenApi();
app.MapScalarApiReference();

app.MapControllers();

app.Run();
