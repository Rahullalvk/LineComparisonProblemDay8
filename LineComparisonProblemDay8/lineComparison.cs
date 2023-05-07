using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblemDay8
{
    internal class lineComparison
    {
        public void CheckEquality()
        {
            Console.WriteLine("Consider lines a & b");
            Console.WriteLine("Enter the cordinates (x1, y1) and (x2, y2):");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x1= :" + x1);
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1= :" + y1);
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2= :" + x2);
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2= :" + y2);
            float length = 0.0f;
            length = (float)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("The length of the line is =" + length);

        }
    }
}
