using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public interface IUser
	{
		void Demo(string s = "Interface");
	}

	public class User : IUser
	{
		enum E { a, b, c };

		public void Demo(string s = "class")
		{
			Console.WriteLine(s);

			E obj = E.c;

			int X =(int) E.a;

			switch (obj)
			{
				case E.a: Console.WriteLine(E.a);
					break;

				case E.b:
					Console.WriteLine(E.b);
					break;

				case E.c:
					Console.WriteLine(E.c);
					break;
			}
		}
}
}
