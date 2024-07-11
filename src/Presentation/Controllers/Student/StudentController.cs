using Domain.IRepository.Student;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers.Student;

public class StudentController(IStudentRepository studentRepository) : Controller
{
    public IStudentRepository StudentRepository => studentRepository;

    [HttpGet("GetStudent")]
    public ActionResult GetStudent(int id, CancellationToken cancellationToken)
    {
        var student = StudentRepository.GetById(id, cancellationToken);
        return Ok(student);
    }
}
