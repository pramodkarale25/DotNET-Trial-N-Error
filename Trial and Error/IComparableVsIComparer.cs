using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public class EmpIComparable : IComparable
	{
		public int id;
		public string name;
		public string dept;
		public int salary;

		public int CompareTo(object obj)
		{
			return salary.CompareTo(((EmpIComparable)obj).salary);
		}
	}

	public class EmpIComparableIComparer
	{
		public int id;
		public string name;
		public string dept;
		public int salary;
	}

	public class EmpIComparer : IComparer<EmpIComparableIComparer>
	{
		public int Compare(EmpIComparableIComparer x, EmpIComparableIComparer y)
		{
			return x.salary.CompareTo(y.salary);
		}
	}

	public class IComparableVsIComparer
	{
		public void Test()
		{
		/*	IComparable is going to help until you have complete control of user-defined class, 
			but let's say you want to apply sorting on a class on which you don't have control.
				Meaning you can't change the implementation of a class; e.g., when you access some class from DLL, 
				you can use them but you can't change their implementation.
			In order to achieve sorting on such classes, the IComparer interface was born.*/

			//IComparable
			List<EmpIComparable> emp = GetEmpListIComparable();
			emp.Sort();
			emp.Reverse();

			//IComparer
			List<EmpIComparableIComparer> emp1 = GetEmpListIComparer();
			EmpIComparer obj = new EmpIComparer();
			emp1.Sort(obj);
			emp1.Reverse();
		}

		private List<EmpIComparable> GetEmpListIComparable()
		{
			List<EmpIComparable> emplst = new List<EmpIComparable>();

			EmpIComparable emp = new EmpIComparable();
			emp.id = 100;
			emp.name = "pramod";
			emp.dept = "IT";
			emp.salary = 100;
			emplst.Add(emp);

			emp = new EmpIComparable();
			emp.id = 20;
			emp.name = "vedanti";
			emp.dept = "software";
			emp.salary = 20;
			emplst.Add(emp);

			emp = new EmpIComparable();
			emp.id = 3;
			emp.name = "vihaan";
			emp.dept = "maintenance";
			emp.salary = 300;
			emplst.Add(emp);

			return emplst;
		}

		private List<EmpIComparableIComparer> GetEmpListIComparer()
		{
			List<EmpIComparableIComparer> emplst = new List<EmpIComparableIComparer>();

			EmpIComparableIComparer emp = new EmpIComparableIComparer();
			emp.id = 100;
			emp.name = "pramod";
			emp.dept = "IT";
			emp.salary = 100;
			emplst.Add(emp);

			emp = new EmpIComparableIComparer();
			emp.id = 20;
			emp.name = "vedanti";
			emp.dept = "software";
			emp.salary = 20;
			emplst.Add(emp);

			emp = new EmpIComparableIComparer();
			emp.id = 3;
			emp.name = "vihaan";
			emp.dept = "maintenance";
			emp.salary = 300;
			emplst.Add(emp);

			return emplst;
		}
	}
}
