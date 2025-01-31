namespace EmployeePortalApi.Entities
{
    public class Profile
    {

        public int IdProfile { get; set; }
        public string? Name { get; set; }

        public virtual  ICollection<Employee>? EmployeesReference { get; set; }

    }
}
