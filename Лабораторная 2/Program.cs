using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static double InputVal(string prompt)
        {
            double a = 0;
            do
                Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out a));
            return a;
        }
        public static class STATE
        {
            public const String Rectangle = "1";
            public const String Sqare = "2";
            public const String Circle = "3";
        }
        static string Menu()
        {
            Console.WriteLine("Выберите фигуру?");
            Console.WriteLine("1. Прямоугольник;");
            Console.WriteLine("2. Квадрат;");
            Console.WriteLine("3. Окружность;");
            Console.WriteLine("4. Выход;");
            string s = Console.ReadLine();
#if AUTOTEST
                Console.WriteLine(s);
#endif
            return s;
        }
        static void ClearScreen()
        {
            Console.WriteLine("Нажмите enter для продолжения ...");
            Console.ReadLine();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            IPrint obj;
            bool exitFlag = false;
            double a1, b1;
            do
            {
                switch (Menu())
                {
                    case STATE.Rectangle:
                        a1 = InputVal("Введите высоту прямоугольника \n");
                        b1 = InputVal("Введите ширину прямоугольника \n");
                        obj = new Rectangle(a1, b1);
                        obj.Print();
                        break;

                    case STATE.Sqare:
                        a1 = InputVal("Введите сторону квадрата \n");
                        obj = new Square(a1);
                        obj.Print();
                        break;

                    case STATE.Circle:
                        a1 = InputVal("Введите радиус окружности \n");
                        obj = new Circle(a1);
                        obj.Print();
                        break;

                    default:
                        exitFlag = true;
                        break;
                }
                ClearScreen();

            } while (!exitFlag);
        }


    }
    interface IPrint
    {
        void Print();
    }
    abstract class GeometricFigure
    {
        public abstract double Area();
        public abstract override string ToString();
    }
    class Rectangle : GeometricFigure, IPrint
    {

        private double h = 0;
        private double w = 0;

        public double H { get => h; set => h = value; }
        public double W { get => w; set => w = value; }
        public Rectangle(double height, double width)
        {
            H = height;
            W = width;
        }
        public override double Area()
        {
            return W * H;
        }
        public override string ToString()
        {
            return "Прямоугольниу: " + W.ToString() + "x" + H.ToString() + ", S = " + Area().ToString();
        }
        public void Print() => Console.WriteLine(this);
    }


    class Square : Rectangle
    {

        public Square(double length) : base(length, length) { }
        public override string ToString()
        {
            return "Квадрат: " + H.ToString() + "x" + H.ToString() + ", S = " + Area().ToString();
        }

    }
    class Circle : GeometricFigure, IPrint
    {
        private double r = 0;

        public double R { get => r; set => r = value; }
        public Circle(double radius)
        {
            R = radius;
        }
        public override double Area()
        {
            return Math.PI * R * R;
        }
        public override string ToString()
        {
            return "Круг: " + R.ToString() + ", S = " + Area().ToString();
        }
        public void Print() => Console.WriteLine(this);
    }
}
