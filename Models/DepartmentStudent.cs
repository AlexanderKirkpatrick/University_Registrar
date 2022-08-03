namespace University_Registrar.Models
{
  public class DepartmentStudent
    {       
        public int DepartmentStudentId { get; set; }
        public int StudentId { get; set; }
        public int DepartmentId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Department Department { get; set; }
    }
}