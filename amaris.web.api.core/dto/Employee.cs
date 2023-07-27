namespace amaris.web.api.core.dto
{
    public class Employee
    {
        public Int64 Id { get; set; }
        public string employee_name { get; set; }
        public decimal employee_salary { get; set; }
        public int employee_age { get; set; }
        public string? profile_image { get; set; }

        public decimal employee_anual_salary
        {
            get => employee_salary *12;
        }
    }
}
