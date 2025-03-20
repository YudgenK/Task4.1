using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task2
    {
        public void Run()
        {
            double side1;
            double side2;

            Console.Write("Введіть довжину першої сторони:");
            bool okSide1= double.TryParse(Console.ReadLine(), out side1);
            if (!okSide1) 
            {
                Console.WriteLine("Значення не вірного формату");
                return; 
            }

            Console.Write("Введіть довжину другої сторони:");
            bool okSide2 = double.TryParse(Console.ReadLine(), out side2);
            if (!okSide2)
            {
                Console.WriteLine("Значення не вірного формату");
                return;
            }


            var rectangle = new Rectangle(side1, side2);

            Console.WriteLine("Площа: "+ rectangle.Area);

            Console.WriteLine("Периметр: " + rectangle.Perimeter);
             
        }
    }
    class Rectangle
    {

        private double side1;
        private double side2;
     
        public Rectangle(double _side1,double _side2)
        {
            side1 = _side1;
            side2 = _side2;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

    }

}
