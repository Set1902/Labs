using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3
{
    using System;

    abstract class Figure : IPrint, IComparable
    {
        abstract public double find_square();

        public void Print()
        {
            System.Console.WriteLine(this.ToString());
        }

        public int CompareTo(Object rhs)
        {
            Figure obj = rhs as Figure;
            if (this.find_square() - obj.find_square() > 0.0001)
            {
                if (this.find_square() < obj.find_square())
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }

        }
    }

    class Rectangle : Figure, IPrint
    {
        public double width { get; set; }
        public double heigth { get; set; }


        public Rectangle(double width1, double heigth1)
        {
            heigth = heigth1; width = width1;
        }

        public override double find_square()
        {
            return heigth * width;
        }

        public override string ToString() => "Прямоугольник " + width.ToString() + " на " + heigth.ToString();

    }

    class Square : Rectangle, IPrint
    {
        public Square(double heigth1) : base(heigth1, heigth1)
        { }

        public override string ToString() => "Квадрат стороной " + heigth.ToString();
    }

    class Circle : Figure, IPrint
    {
        public double radius { get; set; }

        public Circle(double radius1)
        {
            radius = radius1;
        }

        public override double find_square()
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public override string ToString() => "Круг радиусом " + radius.ToString();
    }

    interface IPrint
    {
        void Print();
    }

    class SimpleStack<T> : SimpleList.SimpleList<T> where T : IComparable
    {


        public void Push(T element)
        {
            Add(element);
        }

        public T Pop()
        {

            SimpleList.SimpleListItem<T> itemPopped = last;
            Count = Count - 1;
            if (Count == 0)
            {
                last = null;
                first = null;
            }
            else
            {
                SimpleList.SimpleListItem<T> newLastItem = this.GetItem(Count - 1);
                newLastItem.next = null;
                last = newLastItem;
            }
            return itemPopped.data;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(30, 60);
            Square sqr = new Square(13);
            Circle circle = new Circle(8);
            ArrayList list = new ArrayList();
            list.Add(rect); list.Add(sqr); list.Add(circle);
            list.Sort();
            foreach (Figure obj in list)
            {
                System.Console.WriteLine(obj.GetType().Name);
                obj.Print();
            }
            Console.WriteLine("-------------------------------------------");
            List<Figure> list2 = new List<Figure>();
            list2.Add(rect); list2.Add(sqr); list2.Add(circle);
            list2.Sort();
            foreach (Figure obj in list2)
            {
                System.Console.WriteLine(obj.GetType().Name);
                obj.Print();
            }
            Console.WriteLine("-------------------------------------------");
            SparseMatrix.Matrix<Figure> drop = new SparseMatrix.Matrix<Figure>(2, 2, 1, new Circle(0));
            drop[0, 0, 0] = new Circle(1);
            drop[1, 0, 0] = new Square(2);
            drop[1, 1, 0] = new Rectangle(1, 2);
            System.Console.WriteLine(drop.ToString());
            Console.WriteLine("-------------------------------------------");
            SimpleStack<Figure> primer = new SimpleStack<Figure>();
            primer.Add(circle); primer.Add(rect); primer.Add(sqr);
            primer.Sort();

            for (int i = primer.Count; i > 0; i--)
            {
                System.Console.WriteLine(primer.Pop());
            }
            System.Console.ReadLine();
        }
    }
}
namespace SimpleList
{
    public class SimpleListItem<T>
    {
        public T data { get; set; }

        public SimpleListItem<T> next { get; set; }

        public SimpleListItem(T param)
        {
            this.data = param;
        }
    }

    public class SimpleList<T> : IEnumerable<T>
        where T : IComparable
    {

        protected SimpleListItem<T> first = null;


        protected SimpleListItem<T> last = null;

        public int Count
        {
            get { return _count; }
            protected set { _count = value; }
        }
        int _count;


        public void Add(T element)
        {
            SimpleListItem<T> newItem = new SimpleListItem<T>(element);
            this.Count++;
            if (last == null)
            {
                this.first = newItem;
                this.last = newItem;
            }
            else
            {
                this.last.next = newItem;
                this.last = newItem;
            }
        }
        public SimpleListItem<T> GetItem(int number)
        {
            if ((number < 0) || (number >= this.Count))
            {
                throw new Exception("Выход за границу индекса");
            }

            SimpleListItem<T> current = this.first;
            int i = 0;
            while (i < number)
            {
                current = current.next;
                i++;
            }

            return current;
        }

        public T Get(int number)
        {
            return GetItem(number).data;
        }
        public IEnumerator<T> GetEnumerator()
        {
            SimpleListItem<T> current = this.first;


            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Sort()
        {
            Sort(0, this.Count - 1);
        }
        private void Sort(int low, int high)
        {
            int i = low;
            int j = high;
            T x = Get((low + high) / 2);
            do
            {
                while (Get(i).CompareTo(x) < 0) ++i;
                while (Get(j).CompareTo(x) > 0) --j;
                if (i <= j)
                {
                    Swap(i, j);
                    i++; j--;
                }
            } while (i <= j);

            if (low < j) Sort(low, j);
            if (i < high) Sort(i, high);
        }
        private void Swap(int i, int j)
        {
            SimpleListItem<T> ci = GetItem(i);
            SimpleListItem<T> cj = GetItem(j);
            T temp = ci.data;
            ci.data = cj.data;
            cj.data = temp;
        }
    }
}

namespace SparseMatrix
{
    public class Matrix<T>
    {

        Dictionary<string, T> _matrix = new Dictionary<string, T>();
        int maxX;
        int maxY;

        int maxZ;
        T nullElement;
        public Matrix(int px, int py, int pz, T nullElementParam)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.nullElement = nullElementParam;
        }
        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);
            }
        }
        void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + " выходит за границы");
            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + " выходит за границы");
            if (z < 0 || z >= this.maxY) throw new Exception("z=" + z + " выходит за границы");
        }
        string DictKey(int x, int y, int z)
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }
        public override string ToString()
        {

            StringBuilder b = new StringBuilder();

            for (int k = 0; k < this.maxZ; k++)
            {
                for (int j = 0; j < this.maxY; j++)
                {
                    b.Append("[");
                    for (int i = 0; i < this.maxX; i++)
                    {
                        if (i > 0) b.Append("\t");
                        b.Append(this[i, j, k].ToString());
                    }
                    b.Append("]\n");
                }
                b.Append("\n");
            }

            return b.ToString();
        }

    }
}
