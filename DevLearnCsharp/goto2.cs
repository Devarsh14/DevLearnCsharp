using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevLearnCsharp
{
    class goto2
    {
        int num1;
        int num2;
        
      public int addition()
        {
            Console.WriteLine("Enter first number ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number ");
            num2 = int.Parse(Console.ReadLine());

            int resutl;
            resutl = num1 + num2;

            Console.WriteLine("number is {0}", resutl);
            Console.ReadLine();
            return resutl;

        }
    }
}
