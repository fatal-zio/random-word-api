using EmployeeDataGenerator.Models;
using System.Globalization;

namespace EmployeeDataGenerator.Utilities
{
    internal class EmployeeCsvWriter
    {
        public static void WriteEmployeeCsv(List<Employee> employees, string absoluteFilePath)
        {

            using (var writer = new StreamWriter(absoluteFilePath))
            using (var csv = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(employees);
            }

        }
    }
}
