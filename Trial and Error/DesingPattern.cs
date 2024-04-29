using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public sealed class SingletonDesingPattern
	{
		private static int counter = 0;

		//lazy loading
		private static readonly Lazy<SingletonDesingPattern> singleObject = new Lazy<SingletonDesingPattern>(() => new SingletonDesingPattern());

		//eager loading
		//private static readonly SingletonDesingPattern singleObject1 = new SingletonDesingPattern();

		private SingletonDesingPattern()
		{
			counter++;
			Console.WriteLine(counter);
		}

		public static SingletonDesingPattern GetSDP()
		{
			return singleObject.Value;
		}
	}

	public interface ICalC
	{
		void Calculate(int a, int b);
	}

	class Add : ICalC
	{
		public void Calculate(int a, int b)
		{
			Console.WriteLine(a + b);
		}
	}

	class Multiply : ICalC
	{
		public void Calculate(int a, int b)
		{
			Console.WriteLine(a * b);
		}
	}

	public static class FactoryDP
	{
		public static ICalC GetObj(string type)
		{
			ICalC calcObj = null;

			switch (type)
			{
				case "add":
					calcObj = new Add();
					break;

				case "multiply":
					calcObj = new Multiply();
					break;
			}

			return calcObj;
		}
	}

	public abstract class FactoryMethodDP
	{
		public abstract ICalC GetObj();
	}

	public class FactoryMethodDPAdd : FactoryMethodDP
	{
		public override ICalC GetObj()
		{
			return new Add();
		}
	}

	public class FactoryMethodDPMult : FactoryMethodDP
	{
		public override ICalC GetObj()
		{
			return new Multiply();
		}
	}
}
