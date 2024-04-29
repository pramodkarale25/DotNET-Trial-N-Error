using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public class Inner_Exception
	{
		public void getException()
		{
			try
			{
				int b = 0;
				int a = 1 / b;
			}
			catch (Exception ex)
			{
				try
				{
					var x = new StreamReader("junk");
				}
				catch (Exception e)
				{
					throw new Exception(e.Message, ex);
				}
			}
		}
	}
}
