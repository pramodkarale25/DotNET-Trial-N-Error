using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public interface IInterface
	{
		//const int i=10; not allowed
		//int i; not allowed
	}

	public interface IInterface1 : IInterface
	{

	}

	public class interfaceImpmnt : IInterface, IInterface1 //allowed multiple inheritance with interface
	{

	}

	public abstract class AbsClass
	{

	}

	public abstract class AbsClass1 : AbsClass
	{

	}

	public class AbsClassImpt : AbsClass//, AbsClass1 not allowed multiple inheritance with class
	{

	}
}
