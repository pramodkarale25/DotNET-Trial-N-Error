using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public sealed class SingletonDP
	{
		private static SingletonDP instance;

		private static Lazy<SingletonDP> instanceLazy = new Lazy<SingletonDP>(() => new SingletonDP());

		private static readonly object obj = new object();

		private SingletonDP()
		{

		}

		public static SingletonDP Instance
		{
			get
			{
				if (instance == null)
				{
					lock (obj)
					{
						if (instance == null)
						{
							instance = new SingletonDP();
						}
					}
				}

				return instance;
			}
		}

		public static SingletonDP InstanceLazy
		{
			get
			{
				return instanceLazy.Value;
			}
		}

		public void demo()
		{
			Console.WriteLine("Hello {0}", instance.GetHashCode());
		}
	}
}
