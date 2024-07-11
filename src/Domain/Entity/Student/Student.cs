using Domain.Primitive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Student;
public class Students : BaseEntity<int>
{
    public string? Name { get; set; }
    public int StudentId { get; set; }
    public string? Department { get; set; }
}
