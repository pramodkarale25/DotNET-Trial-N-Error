using System;

namespace Trial_and_Error
{
	public class MyDeletegate
	{
		public delegate int MyDel(int a);

		public int demo(MyDel mydel, int a)
		{
			return mydel(a);
		}

		public int Func(Func<int, int> mydel, int a)
		{
			return mydel(a);
		}

		public void action(Action<int> mydel, int a)
		{
			mydel(a);
		}
	}
}
