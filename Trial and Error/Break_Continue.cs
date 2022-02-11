using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public class Break_Continue
	{
		public void demo()
		{
			for (int i = 0; i < 10; i++)
			{
				if (i == 5)
				{
					continue;
				}

				if (i == 8)
				{
					break;
				}

				Console.WriteLine(i);
			}
		}
	}
}
