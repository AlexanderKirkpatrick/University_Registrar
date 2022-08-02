using System;
using System.Collections.Generic;

namespace University_Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
      CourseComplete = false;
    }
    public int StudentId { get; set; }
    public string Name { get; set; }
    public bool CourseComplete { get; set; }
    public DateTime EnrollmentDate { get ; set; }
    public virtual ICollection<CourseStudent> JoinEntities { get;}
  }
}