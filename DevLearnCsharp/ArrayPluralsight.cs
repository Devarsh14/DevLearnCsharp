using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevLearnCsharp
{
    class ArrayPluralsight
    {
       public void array ()
        {
            string monday = "Monday";
            string[] daysOfWeek = {
                          "MOnday",
                          "Tuesday"
    };

            string tues = daysOfWeek[1];
            Console.WriteLine(tues);
        }


        public void arrraylooping()
        {
            int[] x5 = new int[5] { 22, 33, 55, 66, 54 };

            foreach (int x in x5)
            {
                Console.WriteLine("this is my array{0}", x);
            }


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("New Era array{0}", x5[i]);
            }
        }
    }
}
