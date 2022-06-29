using System;
namespace Revision
{
    public class circle
    {

        public static float _pi;
        int _radius;
        static circle()
            
        {
            Console.WriteLine("Static method called");
            circle._pi = 3.141F;
            
        }
        public circle(int radius)

        {
            Console.WriteLine("instance method called");
            this._radius = radius;
        }
        public static void print()
            {
            //
            }
        public float calculate_area()
        {
            return circle._pi * this._radius * this._radius;
        }
    }
    public class Program
    {

        public static void Main()

        {
            /* circle c1 = new circle(5);
             float area = c1.calculate_area();
             Console.WriteLine("Area = {0}",area);

             circle c2 = new circle(6);
             float area2 = c2.calculate_area();
             Console.WriteLine("Area = {0}", area2);*/

            Console.WriteLine(circle._pi);
        }
     
    
    
    

    }
}