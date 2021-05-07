using System;


namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Birthday birthday_left;
            birthday_left = new Birthday(); //Круто
            Console.WriteLine($"До дня рождения осталось - {birthday_left.BirthdayDaysLeft.TotalDays} дней начиная с {DateTime.Now.ToShortDateString()}");
            Console.ReadKey();
        }
    }
}
