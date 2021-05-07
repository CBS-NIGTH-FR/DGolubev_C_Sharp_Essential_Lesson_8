using System;


namespace Additional_Task
{
    class Birthday
    {
        public TimeSpan BirthdayDaysLeft { get; set; }
        public DateTime MyBirthdayDate { get; set; }



        public Birthday()
        {
            MyBirthdayDate = BirthdayDate();
            BirthdayDaysLeft = DaysLeft(MyBirthdayDate);
        }

        private DateTime BirthdayDate()
        {
            Console.WriteLine("Введите дату своего рождения в формате (yyyy,mm,dd):");
            DateTime date_birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime date_birthday_next = new DateTime(DateTime.Today.Year, date_birthday.Month, date_birthday.Day);
            if (date_birthday_next < DateTime.Now)
            {
                date_birthday_next = new DateTime(DateTime.Today.Year + 1, date_birthday.Month, date_birthday.Day);
            }
            else
            {
                date_birthday_next = new DateTime(DateTime.Today.Year, date_birthday.Month, date_birthday.Day);
            }
            return date_birthday_next;
        }

        private TimeSpan DaysLeft(DateTime date_birthday)
        {
            TimeSpan date_left;
            DateTime date_start = DateTime.Now;

            date_left = date_birthday.Date.Subtract(date_start.Date);

            return date_left;

        }


    }
}
