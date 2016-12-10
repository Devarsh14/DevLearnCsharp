using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevLearnCsharp
{
    class ListExample
    {
        public ListExample()
        {
            var president = new int[5];
            var pres = new List<string>();
            pres.Add("Devarsh");
            pres.Add("Arya shukla");
            pres.Add("Maltiben");
            Console.WriteLine("List of capacity is {0}", pres.Capacity);
            pres.Add("Dev");
           pres.Add("ripal");


           



            //pres.Remove("ripal");
            //pres.RemoveAt(2);


            foreach (string s in pres)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("List of capacity is {0}",pres.Capacity);
        }
    }
}
