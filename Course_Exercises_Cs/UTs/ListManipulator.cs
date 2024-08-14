using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Exercises_Cs.UTs
{
    public static class ListManipulator
    {
        public static int FindMax(List<int> numbers)
        {
            return numbers.Max();
        }


        public static List<int> RemoveDuplicates(List<int> numbers)
        {
            return numbers.Distinct().ToList();
        }

    }
}
