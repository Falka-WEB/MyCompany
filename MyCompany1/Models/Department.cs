namespace MyCompany1.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepName { get; set; } = string.Empty;
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
