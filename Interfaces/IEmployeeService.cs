using DotNetCoreBestPracticesTemplate.Entity;

namespace DotNetCoreBestPracticesTemplate.Interfaces
{
	public interface IEmployeeService
	{
		public Employee GetEmployeeById(long id);
	}
}
