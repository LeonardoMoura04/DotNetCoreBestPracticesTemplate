namespace DotNetCoreBestPracticesTemplate.Entity
{
	public class Employee
	{
		private string _name;
		private int _salary;

		public Employee(string name, int salary)
		{
			_name = name;
			_salary = salary;
		}

		// Public property with a private getter for read-only access
		public string Name => _name;

		// Public property with private getter and setter for controlled access
		public int Salary
		{
			get => _salary;
			private set
			{
				// Additional logic or validation can be added here
				if (value >= 0)
				{
					_salary = value;
				}
			}
		}

		// Public method for modifying the internal state
		public void IncreaseSalary(int amount)
		{
			// Additional logic can be added here
			Salary += amount;
		}
	}
}
