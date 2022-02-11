using System;

namespace Trial_and_Error
{
	public class Tuple
	{
		public void T()
		{
			var b = new Tuple<int, int, string, bool>(1, 2, "pramod", true);
			Console.WriteLine(b.Item1);
			Console.WriteLine(b.Item4);
		}
	}
}
