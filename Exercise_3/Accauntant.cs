using System;


namespace Exercise_3
{
    class Accauntant
    {
        private bool Bonus { get; set; }
        public string ResumeBonus { get; set; }
        Position position;

        public Accauntant(Post worker, int hours)
        {
            Bonus = AskForBonus(worker, hours);
            ResumeBonus = PrintBonus(worker);
        }
        private bool AskForBonus(Post worker, int hours)
        {
            bool bonus = false;
            position = new Position(worker);
            if(hours > position.HoursBonusPosition)
            {
                bonus = true;
            }
            return bonus;
        }

        private string PrintBonus(Post worker)
        {
            string resume_bonus;
            if (Bonus)
            {
                resume_bonus = $"{worker} может получить премию";
            }
            else
            {
                resume_bonus = $"{worker} не может получить премию";
            }
            return resume_bonus;
        }

    }
}
