using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public class Polymorphism
	{
		public virtual void show()
		{
			Console.WriteLine("This is parent class");
		}

		public void show1()
		{
			Console.WriteLine("This is parent class show1");
		}
	}

	public class PolymorphismChild : Polymorphism
	{
		public override void show()
		{
			Console.WriteLine("This is child class");
		}

		public void show1()
		{
			Console.WriteLine("This is child class show1");
		}
	}
}
