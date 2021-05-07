using System;


namespace Exercise_2
{
    enum Colors
    {
        Yellow,
        Green,
        Blue,
        Red,
        White
    }
    
    static class PrinterProperties
    {
        
        public static void Print(string stroka, int color)
        {
            Colors colors = (Colors)Enum.GetValues(typeof(Colors)).GetValue(color);
            try
            {
                switch ((int)colors)
                {
                    case 0:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(stroka);
                            break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(stroka);
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(stroka);
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(stroka);
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(stroka);
                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(stroka);
                            break;
                        }
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели не существующий цвет");
            }
        }
    }
}
