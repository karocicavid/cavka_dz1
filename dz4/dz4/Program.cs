using System;

namespace dz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Money manat = new Money();
            Console.Write("Введите номинал купюры - ");
            manat.first = int.Parse(Console.ReadLine());
            Console.Write("Введите количество купюр - ");
            manat.second = int.Parse(Console.ReadLine());
            if(manat.first<=0 || manat.second <= 0) { Console.Write("Введены невалидные данные!");return; }
            Console.Write("Введите Введите стоимость товара - ");
            manat.item_price = int.Parse(Console.ReadLine());
            if (manat.item_price <= 0) { Console.WriteLine("Замечена Халява!"); return; }
            manat.Manat();
            manat.Bool();
            manat.Item();
        }
    }
    
    class Money
    {
        public int item_price { set; get; }
        public int first { set; get; }
        private int x;
        public int second
        {
            set { Console.WriteLine("Сумма денег = " + value * first);x = value; }
            get { return x; }
        }
        
        

        public Money() {}
        public void Manat() { Console.WriteLine($"Номинал купюры - {first} AZN ,количество купюр - {second}"); }
        public void Bool()
        {
            if ((first * second) > item_price & item_price > 0) { Console.WriteLine("Сможем покупать!"); }
            else if (item_price <= 0) { Console.WriteLine("Упс!"); }
            else { Console.WriteLine("Не хватает денег на покупку!"); }
        }
        public void Item()
        {
            int quantity = (first * second) / item_price;
            Console.WriteLine($"{quantity} штук товара сможем покупать за {first * second} AZN");
        }

    }
}
