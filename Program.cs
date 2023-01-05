using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison237
{
    internal class GeometryLineComputataion
    {

        public static double LineDistance()
        {
            Console.WriteLine("Enter the first coordinates (x1 & y1) : ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinates (x2 & y2) : ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double d1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));    //with using Pow function.
            Console.WriteLine($"Co-ordinates provided are as follows (x1,y1),(x2,y2) : ({x1},{y1}),({x2},{y2})");
            Console.WriteLine($"After calculating , Line distance value is : {d1}\n");
            return d1;
        }
        public static void EqualsMethod(double line1Distance, double line2Distance)     //Equals()
        {
            bool EqualsStatus = line1Distance.Equals(line2Distance);
            if (EqualsStatus)
            {
                Console.WriteLine("As per the result , Length value of both Line 1 and Line 2 are EQUAL (using Equals())");
            }
            else
            {
                Console.WriteLine("As per the result ,Length value of Line 1 and Line 2 are NOT equal (using Equals())");
            }
        }
        public static void CompareMethod(double line1Distance, double line2Distance)    //CompareTo()
        {
            int CompareToStatus = line1Distance.CompareTo(line2Distance);
            if (CompareToStatus == 0)
            {
                Console.WriteLine("Both first and second lines are having Equal Length. (using CompareTo())");
            }
            else if (CompareToStatus < 0)
            {
                Console.WriteLine("Length of first line is Less than second line.  (using CompareTo())");
            }
            else
            {
                Console.WriteLine("Length of first line is Greater than second line.  (using CompareTo())");
                {
                }
            }
        }
    }
}