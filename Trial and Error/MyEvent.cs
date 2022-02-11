using System;

namespace Trial_and_Error
{
	public class MyEvent
	{
		public event Action<Object, MyEventArgs> MyeventDelagate;

		public void RaiseEvent(string name)
		{
			MyeventDelagate?.Invoke(this, new MyEventArgs() { Name = name });
		}
	}

	public class MyEventArgs
	{
		public string Name { get; set; }
	}
}
