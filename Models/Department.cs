using System.Collections.Generic;

namespace University_Registrar.Models
{
    public class Department
    {
        public Department()
        {
            this.JoinEntities = new HashSet<DepartmentStudent>();
            this.JoinDeptCourse = new HashSet<DepartmentCourse>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DepartmentStudent> JoinEntities { get; set; }
        public virtual ICollection<DepartmentCourse> JoinDeptCourse { get; set; }
    }
}