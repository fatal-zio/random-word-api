namespace EmployeeDataGenerator.Models
{
    internal class ApiSettings
    {
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }
        public string FirstNameUrl { get; set; }
        public string LastNameUrl { get; set; }
        public string DefaultFileLocation { get; set; }
        public string DefaultFileName   { get; set; }
        public int DefaultEmployeeCount { get; set; }
    }
}
