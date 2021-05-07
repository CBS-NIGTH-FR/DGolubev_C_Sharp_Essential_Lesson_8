using System;


namespace Exercise_3
{
    enum Post
    {
        Supervisor = 186,
        ChiefSpecialist = 152,
        Specialist = 139,
        SystemInstaller = 143
    }
    class Position
    {
        public int HoursBonusPosition { get; private set; }
        public Position(Post post)
        {
            HoursBonusPosition = (int)Enum.Parse(typeof(Post), post.ToString());
        }
    }
    

        
       
    
}
