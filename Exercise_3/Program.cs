using System;


namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant;
            accauntant = new Accauntant(Post.Supervisor, 155);
            Console.WriteLine(accauntant.ResumeBonus);
            Console.WriteLine();
            accauntant = new Accauntant(Post.Supervisor, 192);
            Console.WriteLine(accauntant.ResumeBonus);
            Console.WriteLine();
            accauntant = new Accauntant(Post.ChiefSpecialist, 165);
            Console.WriteLine(accauntant.ResumeBonus);
            Console.WriteLine();
            accauntant = new Accauntant(Post.Specialist, 138);
            Console.WriteLine(accauntant.ResumeBonus);
            Console.WriteLine();
            accauntant = new Accauntant(Post.SystemInstaller, 170);
            Console.WriteLine(accauntant.ResumeBonus);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
