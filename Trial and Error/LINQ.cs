using System.Collections.Generic;
using System.Linq;

namespace Trial_and_Error
{
	public class LINQ
	{
		public void Test()
		{
			int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var b = a.Where(x => (x % 2) == 0);

			int min = a.Min();
			int max = a.Max();
			int sum = a.Where(x => x != 10).Sum();

			var minX = from aa in a
					   where (aa % 2) == 0
					   select aa;
			List<Emp> emplst = GetEmpList();

			var emp = emplst.Where(x => 1 == 1).OrderBy(x => x.id).Select(z => new { z.id, z.name });

			var emp1 = from em in emplst
					   where 1 == 1
					   from idname in em.name
					   where 1 == 1
					   select idname;

			//find nth max salary
			int n = 2;

			var xxx = emplst.OrderByDescending(x => x.salary).First();
			xxx = emplst.OrderByDescending(x => x.salary).Skip(n).First();

			// first vs firstordefault
			n = 10;
			//xxx = emplst.OrderByDescending(x => x.salary).Skip(n).First();// return error 
			xxx = emplst.OrderByDescending(x => x.salary).Skip(n).FirstOrDefault();// does not throw exception but gives null value

			//skip vs skipwhile
			xxx = emplst.OrderByDescending(x => x.salary).SkipWhile(x => x.salary < 20).FirstOrDefault();

		}

		private List<Emp> GetEmpList()
		{
			List<Emp> emplst = new List<Emp>();

			Emp emp = new Emp();
			emp.id = 100;
			emp.name = "pramod";
			emp.dept = "IT";
			emp.salary = 10;
			emplst.Add(emp);

			emp = new Emp();
			emp.id = 20;
			emp.name = "vedanti";
			emp.dept = "software";
			emp.salary = 20;
			emplst.Add(emp);

			emp = new Emp();
			emp.id = 3;
			emp.name = "vihaan";
			emp.dept = "maintenance";
			emp.salary = 30;
			emplst.Add(emp);

			return emplst;
		}
	}

	public class Emp
	{
		public int id;
		public string name;
		public string dept;
		public int salary;
	}
}