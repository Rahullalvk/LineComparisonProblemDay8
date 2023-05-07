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
            int x1a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x1= :" + x1a);
            int y1a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1= :" + y1a);
            int x2a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2= :" + x2a);
            int y2a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2= :" + y2a);
            float length1 = (float)Math.Sqrt((x2a - x1a) ^ 2 + (y2a - y1a) ^ 2);
            Console.WriteLine("The length of first line =" + length1);

            Console.WriteLine("Enter the cordinates (x1, y1) and (x2, y2):");
            int x1b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x1= :" + x1b);
            int y1b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1= :" + y1b);
            int x2b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2= :" + x2b);
            int y2b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2= :" + y2b);
            float length2 = (float)Math.Sqrt((x2b - x1b) ^ 2 + (y2b - y1b) ^ 2);
            Console.WriteLine("The length of second line =" + length2);

            if (length1 == length2)
            {
                Console.WriteLine("Two lines a and b are equal");

            }
            else
            {
                Console.WriteLine("Two lines a and b are not equal");
            }
        }
    }
}
