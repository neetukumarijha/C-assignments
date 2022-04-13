using System;

namespace circumference
{
    class CirlceAreaCircumference
    {
        static void calculateAreaCircumference()
        {
            double radius, area, circumference;
            const double PI = 3.14;
            Console.Write("\nEnter the radius of circle ");
            radius = Convert.ToDouble(Console.ReadLine());

            circumference = 2 * PI * radius;
            Console.WriteLine("Circumference of Circle : {0}", circumference);

            area = PI * radius * radius;
            Console.WriteLine("\nThe area of circle is : {0}", area);
            Console.ReadLine();

        }

        static void Main(String[] args)
        {
            CirlceAreaCircumference.calculateAreaCircumference();
        }
    }
}
