namespace EmployeePortalApi.Entities
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public string? FullName { get; set; }

        public int Salary { get; set; }

        public bool IdPerfil { get; set; }

        public virtual required Perfil PerfilReference { get; set; }
    }
}
