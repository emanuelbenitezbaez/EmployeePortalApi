namespace EmployeePortalApi.Entities
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public string? FullName { get; set; }

        public int Salary { get; set; }

        public int IdProfile { get; set; }

        public virtual  Profile? ProfilesReference { get; set; }
    }
}
