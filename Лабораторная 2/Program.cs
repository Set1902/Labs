using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2
{
    class Program
 
    {
        static void Main(string[] args)
        {
        Console.Title = "Ковалев Сергей ИУ5-32Б";
        double a, b, c, d;
            Console.WriteLine("Введите длину и высоту прямоугольника");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(a, b);
            rect.Print();
            Console.ReadKey();
            Console.WriteLine("Введите сторону квадрата");
            c = double.Parse(Console.ReadLine());
            Square square = new Square(c);
            square.Print();
            Console.ReadKey();
            Console.WriteLine("Введите радиус круга");
            d = double.Parse(Console.ReadLine());
            Circle circle = new Circle(d);
            circle.Print();
            Console.ReadKey();
            System.Environment.Exit(0);
            Console.ReadLine();
        }
    }
    // Абстрактный класс «Геометрическая фигура» 
    abstract class Figure
    {
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        public abstract double Area();

        public override string ToString()
        {
            return this._Type + this.Area().ToString();
        }
    }
    // Интерфуйс IPrint
    interface IPrint
    {
        void Print();
    }
    // Класс круг
    class Circle : Figure, IPrint
    {
        double radius;

        public Circle(double rd)
        {
            this.radius = rd;
            this.Type = "Площадь круга = ";
        }

        public override double Area()
        {
            double result = Math.PI * this.radius * this.radius;
            return result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    // Класс прямоугольник
    class Rectangle : Figure, IPrint
    {
        double height;
        double width;

        public Rectangle(double hg, double wd)
        {
            this.height = hg;
            this.width = wd;
            this.Type = "Площадь прямоугольника = ";
        }

        public override double Area()
        {
            double result = this.height * this.width;
            return result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    // Класс квадрат
    class Square : Rectangle
    {

        public Square(double length) : base(length, length) { }
        public override string ToString()
        {
            return "Площадь квадрата =  " + Area().ToString();
        }

    }
}
