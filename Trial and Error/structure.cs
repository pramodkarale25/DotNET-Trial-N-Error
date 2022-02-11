using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	struct ST
	{
		//int a = 10; not allowed
		const int abc = 10;//allowed
		int a;

		decimal b;
		char c;

		ST(int abc)//parameter less constructor not allowed.
		{
			//we have to assign these values before return
			a = 10;
			b = 20;
			c = 'a';
		}

		void test()
		{
			ST s = new ST(10);
		}

	}
}
