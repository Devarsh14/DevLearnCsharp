using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevLearnCsharp
{
    class IntegerStdInPUT
    {
        public void IntegerStdInPut()
        {
            int a;
        dev:
            Console.WriteLine("Enter any number");
            string entervalue = Console.ReadLine();
            int outvalue;


            bool y = int.TryParse(entervalue, out outvalue);
            if (y == false)
            {
                goto dev;
            }
            Console.WriteLine(outvalue);



        }



    }
}
