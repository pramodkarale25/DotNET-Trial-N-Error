using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public class TryCatch
	{
		public TryCatch()
		{
			Test();
		}

		public void Test()
		{
			try
			{
				throw new Exception();
			}
			catch
			{
				//control come here
			}

			try
			{
				throw new Exception();
			}
			catch (Exception ex)
			{
				//control come here
			}


			try
			{
				throw new Exception();
			}
			finally
			{
				//control come here
			}
		}
	}
}
