using System;


namespace Exercise_2
{
    class Print
    {
        public static void PrintManual()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Выберите номер цвета:\nYellow = 0\nGreen = 1\nBlue = 2\nRed = 3\nWhite = 4");
            int color = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            PrinterProperties.Print(text, color);
        }
        public static void PrintAuto()
        {
            PrinterProperties.Print("Я люблю C#", 0);
            PrinterProperties.Print("Я люблю C#", 1);
            PrinterProperties.Print("Я люблю C#", 2);
            PrinterProperties.Print("Я люблю C#", 3);
            PrinterProperties.Print("Я люблю C#", 4);
        }
    }
}
