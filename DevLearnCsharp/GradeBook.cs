using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevLearnCsharp
{
    class GradeBook
    {
        List<float> grades; // declared list and intiated in constroctor

        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
       

    }
}
