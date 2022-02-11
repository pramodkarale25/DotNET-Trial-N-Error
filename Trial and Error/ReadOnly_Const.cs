using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public class ReadOnly_Const
	{
		//we can not change const variable
		public const int abc = 1;
		// we can not declare const variable as static as const is by default static
		//public static const int a = 1;

		// we can only able to change readonly variable inside public instance constructor.
		public readonly int xyz;

		// we can only able to change static readonly variable inside static constructor.
		public static readonly int pqr;

		public ReadOnly_Const()
		{
			xyz = 2;
		}

		static ReadOnly_Const()
		{
			pqr = 3;
		}

		public void demo()
		{
			//We can declare const variable inside function
			const int abc = 1;

			//We can not declare readonly variable inside function
			// readonly int xyz;

			ReadOnly_Const obj = new ReadOnly_Const();
			Console.WriteLine(ReadOnly_Const.abc);
			//Console.WriteLine(obj.abc);
			Console.WriteLine(obj.xyz);
			Console.WriteLine(ReadOnly_Const.pqr);
		}
	}
}
