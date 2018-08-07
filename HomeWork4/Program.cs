using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ran = new Random().Next(1, 100);
            Console.WriteLine("從1到100共100個整數範圍的任意數為:" + ran);

            Console.WriteLine("################################");

            string guess;
            int g;
            start:
            Console.WriteLine("");
            Console.Write("請輸入一個從1到100的整數:");
            guess = Console.ReadLine();
            Console.WriteLine("\n");
            g = int.Parse(guess);
            if (g <= 100)
            {
                if (g == ran)
                {
                    Console.WriteLine("猜對了!");
                }
                else if (g < ran)
                {
                    Console.WriteLine("猜太小了，請往大一點的方向猜");
                    goto start;
                }
                else
                {
                    Console.WriteLine("猜太大了，請往小一點的方向猜");
                    goto start;
                }
            }
            else
            {
                goto start;

            }
            Console.WriteLine("\n");
            Console.Write("使用者猜的整數為:");
            Console.WriteLine(g);
        }
    }
}
