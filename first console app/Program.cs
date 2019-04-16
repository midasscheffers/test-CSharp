using System;

namespace first_console_app
{
	class Program
	{
        public static Rabbit r = new Rabbit(20);

		static void Main(string[] args)
		{
            long[] list = r.MakeFiboList(r.age);
            foreach (long Item in list)
            {
                Console.WriteLine(Item);
            }
        }

        


    }

    
}
