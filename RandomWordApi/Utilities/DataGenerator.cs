using EmployeeDataGenerator.Models;

namespace EmployeeDataGenerator.Utilities
{
    internal class DataGenerator
    {
        private static int GenerateId()
        {
            var random = new Random();
            return random.Next(100000);
        }

        private static decimal GenerateAnnualFlexCredit()
        {
            return GenerateRandomDecimal();
        }

        private static decimal GenerateAnnualFlexSalary()
        {
            return GenerateRandomDecimal();
        }

        private static decimal GenerateRandomDecimal()
        {
            var random = new Random();
            var randomDecimal = new decimal(random.Next(0, 50000));
            return randomDecimal * new decimal(.01);
        }

        public static List<Employee> GenerateEmployees(List<string> firstNames, List<string> lastNames)
        {
            var employeesToReturn = new List<Employee>();

            if (firstNames != null && lastNames != null)
            {
                if (firstNames.Count != lastNames.Count)
                    throw new ArgumentException("First Names and Last Names must have an equal number.");
            }
            else
            {
                throw new ArgumentException("First Names and Last Names must have a non-zero number.");
            }

            for (int i = 0; i < firstNames.Count; i++)
            {
                employeesToReturn.Add(new Employee(GenerateId(), firstNames[i], lastNames[i], GenerateAnnualFlexSalary(), GenerateAnnualFlexCredit()));
            }

            return employeesToReturn;
        }
    }
}
