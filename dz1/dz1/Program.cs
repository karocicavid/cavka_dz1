using System;


namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point num = new Point();
            Console.Write("Введите обсциссу-");
            num.abscissa = int.Parse(Console.ReadLine());
            Console.Write("Введите ординату-");
            num.ordinate = int.Parse(Console.ReadLine());
            num.Getpoint();
            num.GetDistance();
        }
    }

    class Point
    {
        public int abscissa { get; set; }
        private int x;
        public int ordinate
        {
            set { Console.WriteLine($"точки координат -  {abscissa},{value}"); x=value; }
            get { return x; }
        }
        
        public Point() { }
        public Point(int a,int b) { a = 0;b = 0;}
        public void Getpoint() { Console.WriteLine($"Абсцисса {abscissa}, ордината {ordinate}"); }
        public void GetDistance()
        {
            double distance = Math.Sqrt((abscissa * abscissa) + (ordinate * ordinate));
            Console.WriteLine($"Расстояние = {distance}");
        }
    }
}