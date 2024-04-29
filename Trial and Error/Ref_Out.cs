using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public class Ref_Out
	{
		public Ref_Out()
		{
			int a = 10;

			int b;

			Test(ref a);

			Test1(out b);
		}

		public void Test(ref int a)
		{
			a++;
		}

		public void Test1(out int b)
		{
			b=20 ;
		}
	}
}
