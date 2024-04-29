using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public class IsVsAs
	{
		public void demo()
		{
			EmployeeIsVsAs obj = new EmployeeIsVsAs();

			//EmployeeIsVsAs obj = new Employee_PermanentIsVsAs();

			if (obj is Employee_PermanentIsVsAs)
			{
				Console.WriteLine("obj is Employee_PermanentIsVsAs");
			}
			else
			{
				Console.WriteLine("obj is not Employee_PermanentIsVsAs");
			}

			if (obj is EmployeeIsVsAs)
			{
				Console.WriteLine("obj is EmployeeIsVsAs");
			}
			else
			{
				Console.WriteLine("obj is not EmployeeIsVsAs");
			}


			Employee_PermanentIsVsAs obj1 = obj as Employee_PermanentIsVsAs;

			if (obj1 == null)
			{
				Console.WriteLine("obj1 is null");
			}
			else
			{
				Console.WriteLine("obj1 is not null");
			}

			Employee_ContracttIsVsAs obj2 = obj as Employee_ContracttIsVsAs;

			if (obj2 == null)
			{
				Console.WriteLine("obj2 is null");
			}
			else
			{
				Console.WriteLine("obj2 is not null");
			}
		}
	}

	public class EmployeeIsVsAs
	{

	}

	public class Employee_PermanentIsVsAs : EmployeeIsVsAs
	{

	}

	public class Employee_ContracttIsVsAs : EmployeeIsVsAs
	{

	}
}
