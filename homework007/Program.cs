using System;

namespace homework007
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTime;
            string text;
            Console.Write("Введите текст: ");
            text = Convert.ToString (Console.ReadLine());
            Console.Write("Введите количество повторов текста: ");
            numberOfTime = Convert.ToInt32(Console.ReadLine());
            while (numberOfTime > 0)
            {
                Console.WriteLine(text);
                numberOfTime--;
            }
        }
    }
}
