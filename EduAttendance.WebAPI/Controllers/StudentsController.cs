using EduAttendance.WebAPI.Context;
using EduAttendance.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduAttendance.WebAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public sealed class StudentsController(ApplicationDbContext dbContext) : ControllerBase
{
    
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        var students = await dbContext.Students.ToListAsync();
        return Ok(students);
    }
}
