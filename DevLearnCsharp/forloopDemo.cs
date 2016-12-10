using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevLearnCsharp
{
    class forloopDemo
    {
        public void fordemo()
        {
            for (int k = 0; k < 38; k++)
            {
                Console.WriteLine("this is numbler{0}", k);
                if (k==20)
                {
                    Console.WriteLine("Break time");

                    Console.ReadLine();
                    break;


                }

            }
        }
    }
}
