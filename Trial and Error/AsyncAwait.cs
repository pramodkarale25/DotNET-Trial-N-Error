using System;
using System.Threading;
using System.Threading.Tasks;

namespace Trial_and_Error
{
    public class AsyncAwait
    {
        public void TestCase1()
        {
            //if we need return value
            //var x = M2();
            //var y = M3();
            //var z = M4();

            //if we are not depend on return value
            M2();
            M3();
            M4();
        }


        public static async Task M2()
        {
            for (int i = 0; i < 7; i++)
            {
                await Task.Delay(1000);// when control reachech here then only it is releasing thread and then only
                //next call goes to M3()
                Console.WriteLine("M2 " + i);
            }
        }

        public static async Task M3()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("M3 " + i);
                await Task.Delay(500);
                //await M5();
            }
        }

        public static async Task M4()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("M4 " + i);
            }
        }

        public static async Task M5()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("M5 " + i);
            }
        }

    }
}
