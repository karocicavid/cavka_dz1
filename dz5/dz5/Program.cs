
using System;
class Program
{
    static void Main(string [] args)
    {
        Massiv first = new Massiv();

        first.Size();
        first.Input();
        first.Show();
        first.Sort();
    } 
}
class Massiv
{
    private int x;
    public int n
    {
        set { Console.WriteLine("Размер массива - " + value);x = value; }
        get { return x; }
       
    }
    public int[] IntArray;

    public Massiv()
    {
        int[] IntArray = new int[x];
    }

    public void Size()
    {
        Console.Write("Введите размер массива : ");
        n = int.Parse(Console.ReadLine());
        if (x > 0) { IntArray = new int[x]; }
        else { Console.WriteLine("Введены невалидные данные!"); }
        
    }

    public void Input()
    {
        for (int i = 0; i < x; i+=1)
        {
            Console.Write("Введите число массива : ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0) { IntArray[i] = a; }
            else { Console.WriteLine("Введены невалидные данные!"); }
        }
    }
    public void Show()
    {
        Console.Write("Массив - ");
        foreach (int x in IntArray)
        {
            Console.Write($"{x},");
        }
        Console.WriteLine();
    }
    public void Sort()
    {
        Console.Write("Осортированный массив - ");
        int temp;
        for(int i = 0; i < IntArray.Length ; i++)
        {    int min = i;
            for(int j =i + 1; j < IntArray.Length; j++)
            {
                if(IntArray[min]> IntArray[j])
                {
                    min = j;
                }
            }
            temp = IntArray[min];
            IntArray[min]= IntArray[i];
            IntArray[i] = temp;
            Console.Write(temp+",");
        }
    }
}