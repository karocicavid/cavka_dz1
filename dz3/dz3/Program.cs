using System;
using System.Drawing;

namespace dz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle first = new Rectangle();
            Console.Write("Введите первую сторону прямоугольника - ");
            first.side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону прямоугольника - ");
            first.side2 = double.Parse(Console.ReadLine());
            if (first.side1 <= 0 || first.side2 <= 0) { Console.Write("Введите правильные данные "); return;}
            first.Length();
            first.Perimeter();
            first.Area();
            
        }
    }

    class Rectangle
    {
        public double side1 { get; set;}
        private double x;
        public double side2
        {
            set
            {   
                if (side1 == value & side1>=0 && side1 >=0) { Console.WriteLine("Ваш прямоугольник - квадрат"); x = value; }
                else if(side1 >= 0 & side1 >= 0) {  Console.WriteLine("Ваш прямоугольник - не квадрат"); x = value; }
            }
            get { return x;}
        }
    public  Rectangle() {}
    public void Length() { Console.WriteLine($"Длина сторон прямоугольника -  {side1}, {side2} см"); }
    public void Perimeter() { Console.WriteLine($"Периметр прямоугольника = {(side1 + side2) * 2} см"); }
    public void Area() { Console.WriteLine($"Площадь прямоугольника =   {side1 * side2} см"); }
    }
    
    
}
