namespace EmployeeDataGenerator.Models
{
    internal class Employee(int id, string firstName, string lastName, decimal annualFlexSalary, decimal annualFlexCredit)
    {
        public int Id { get; set; } = id;
        public string? FirstName { get; set; } = firstName;
        public string? LastName { get; set; } = lastName;
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string Email
        {
            get
            {
                return $"{FirstName}.{LastName}@mbll.ca";
            }
        }
        public decimal? AnnualFlexSalary { get; set; } = annualFlexSalary;
        public decimal? AnnualFlexCredit { get; set; } = annualFlexCredit;
    }
}
