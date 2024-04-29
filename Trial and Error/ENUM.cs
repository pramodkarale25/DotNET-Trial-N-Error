using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public class ENUM
	{
		enum Level
		{
			Low,
			Medium,
			High
		}

		public void Demo()
		{
			Level myVar = Level.Medium;
			Console.WriteLine(myVar);
			Console.ReadLine();
		}
	}
}
