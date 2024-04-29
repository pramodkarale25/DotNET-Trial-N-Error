using System;

namespace Trial_and_Error
{
	class Program
	{
		enum Level
		{
			Low,
			Medium,
			High
		}

		static void Main(string[] args)
		{
			#region IComparableVsIComparer

			//IComparableVsIComparer Cobj = new IComparableVsIComparer();
			//Cobj.Test();

			#endregion

			#region Enum

			//Level myVar = Level.Medium;
			//Console.WriteLine(myVar);
			//Console.ReadLine();

			#endregion

			#region Test Knowledge
			//User objTK = new User();
			//objTK.Demo();//Demo("A");
			//IUser ITK = objTK;
			//ITK.Demo();//Demo("B");
			//((User)ITK).Demo();//Demo("C");
			//Console.ReadLine();
			#endregion

			#region SingletonDP
			//SingletonDesingPattern objSDP = SingletonDesingPattern.GetSDP();

			//Console.WriteLine(objSDP.GetHashCode());
			//objSDP = SingletonDesingPattern.GetSDP();

			//Console.WriteLine(objSDP.GetHashCode());
			#endregion

			#region LINQ

			LINQ lnq = new LINQ();
			lnq.Test();

			#endregion

			#region Polymorphism
			//Polymorphism obj = new Polymorphism();
			//obj.show();
			//obj.show1();

			//obj = new PolymorphismChild();
			//obj.show();
			//obj.show1();

			//PolymorphismChild obj21 = new PolymorphismChild();
			//obj21.show1();
			#endregion

			#region TRY CATCH
			//try
			//{
			//	TryCatch ex = new TryCatch();
			//}
			//catch (Exception e)
			//{

			//}
			#endregion

			#region INNER EXCEPTION
			//try
			//{
			//	Inner_Exception ex = new Inner_Exception();
			//	ex.getException();
			//}
			//catch (Exception e)
			//{

			//}

			#endregion

			#region Is vs As
			//IsVsAs obj = new IsVsAs();
			//obj.demo();
			#endregion

			#region Abstract class
			//AbstractClass obj = new AbstractClass();
			#endregion

			#region Jagged 

			//string[][] a = new string[3][];
			//a[0] = new string[2];
			//a[1] = new string[1];
			//a[2] = new string[5];

			#endregion

			#region event

			//MyEvent evnt = new MyEvent();

			////attach delegate
			//evnt.MyeventDelagate += MyTempDel;

			//evnt.RaiseEvent("Pramod");
			#endregion

			#region delegate
			//MyDeletegate obj = new MyDeletegate();
			////obj.MyDel;//not possible, delegate is not an instance member

			//MyDeletegate.MyDel delobj;//possible

			//obj.demo(mult, 5);
			//obj.Func(mult, 5);
			//obj.action(Console.WriteLine, 5);

			//obj.demo(a => a * a, 5);
			//obj.Func(a => a * a, 5);
			//obj.action(Console.WriteLine, 5);
			#endregion

			#region AsyncAwait
			//AsyncAwait x = new AsyncAwait();

			//x.TestCase1();

			#endregion


			#region SQL
			SQL sql = new SQL();
			sql.BulkInsert();
			#endregion

			Console.ReadLine();
		}

		static int mult(int a) => a * a;

		static void MyTempDel(object sender, MyEventArgs args)
		{
			Console.WriteLine(args.Name);
		}
	}
}
