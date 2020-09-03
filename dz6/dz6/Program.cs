using System;

namespace dz6
{
    class Program
    {
        static void Main(string[] args)
        {
            Massiv first = new Massiv();
            first.Index();
            first.Get();
            first.Input();
            first.Show();
            first.Sort();
        }
    }

    class Massiv
    {
        public double[,] DoubleArray;
        public int n;
        private int a;
        public int m { set { Console.WriteLine("Колво чисел = " + value * n); a = value; } get { return a;} }
       


        public Massiv() { }
       
        

        public void Get() { DoubleArray = new double[n, a]; }
        public void Index()
        {
            Console.Write("Введите кол-во групп массива : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во чисел в группах : ");
            int y = int.Parse(Console.ReadLine());
            n = x;
            m = y;
           
        }

        public void Input()
        {
            Console.Write("Введите числа массива: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    DoubleArray[i, j] = double.Parse(Console.ReadLine());

                }
                
            }
        }
        public void Show()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a; j++)
                {

                    Console.Write(DoubleArray[i, j] + ",");
                }
                Console.WriteLine();
            }
        }

        public void Sort()
        {
            for (int i = 0; i < n; i++)
            {
                double temp;
                for (int j = 0; j < a-1; j++)
                {
                    int min = j;
                    for(int k = j+1; k < a; k++)
                    {
                        if(DoubleArray[i,min] > DoubleArray[i, k])
                        {
                            min = k;
                        }
                    }
                    temp = DoubleArray[i, j];
                    DoubleArray[i, j] = DoubleArray[i, min];
                    DoubleArray[i, min] = temp;
                }
               
            }
            Console.WriteLine("Отсортированный массив:");
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < a; y++)
                {

                    Console.Write(DoubleArray[x, y] + ",");
                }
                Console.WriteLine();
            }

        }

    }
}
