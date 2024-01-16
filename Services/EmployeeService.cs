using DotNetCoreBestPracticesTemplate.Entity;
using DotNetCoreBestPracticesTemplate.Interfaces;

namespace DotNetCoreBestPracticesTemplate.Services
{
	public class EmployeeService : IEmployeeService
	{
		public Employee GetEmployeeById(long id)
		{
			// Logic to retrieve the employee from the database by id.

			return new Employee("Test Employee", 10000);
		}
	}
}
