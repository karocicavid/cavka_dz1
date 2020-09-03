using System;

namespace cavka
{
    class check
    {
        static void Main(string[] args) 
        {
            Triangle num = new Triangle();
            Console.Write("Введите первую сторону - ");
            num.first = int.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону - ");
            num.second = int.Parse(Console.ReadLine());
            Console.Write("Введите третью сторону - ");
            num.third = int.Parse(Console.ReadLine());
            if (num.first <= 0 || num.second <= 0 || num.third <= 0) { Console.WriteLine("Длина сторон не должна быть меньше нуля!");return ;}
            num.Sides();
            num.Perimeter();
            num.Area();
        }
    }
    
    class Triangle
    {
        public int first;
        public int second;
        private int y;
        public int third
        {
            set
            {
                if (first >= second + value || second >= first + value || value >= first + second) { Console.WriteLine("Не существующий треугольник!");}
                y = value;
            }
            get { return y;}
        }
        public Triangle(int x,int y,int z){ }//этот конструктор(не работает в этом случае)
        public Triangle() { }

        public void Sides() { Console.WriteLine($"Длина сторон треугольника - {first},{second},{third} см");}
        public void Perimeter() { Console.WriteLine($"Периметр  треугольника = {first + second + third} см"); }
        public void Area()
        {
            int p = first + second + third;
            int total = p * (p - first) * (p - second) * (p - third);
            Console.WriteLine("Площадь треугольника = "+Math.Sqrt(total));
        }

    }
}