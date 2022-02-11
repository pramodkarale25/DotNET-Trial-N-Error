using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public abstract class Employee
	{
		public string firstName;
		public string lastName;
		public int id;
		public abstract int GetMonthlySalary();
	}

	public class Employee_Permanent : Employee
	{
		int annualSalary;
		public override int GetMonthlySalary()
		{
			return annualSalary / 12;
		}

		public string GetFullName()
		{
			return string.Concat(firstName, lastName);
		}
	}

	public class Employee_Contractt : Employee
	{
		int hrsPay;
		int TotalHrs;
		public override int GetMonthlySalary()
		{
			return hrsPay * TotalHrs;
		}
	}
}
