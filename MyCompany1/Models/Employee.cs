namespace MyCompany1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        public string Position { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; } = new Department();
    }
}
