using EduAttendance.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EduAttendance.WebAPI.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options): base(options)
    {         
    }
    public DbSet<Student> Students { get; set; }
}
