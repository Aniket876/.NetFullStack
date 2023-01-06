using System;

namespace Assignment5_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] India = new Player[5]
            {
                new Player("Rohit",50),
                new Player("Virat",100),
                new Player("Hardik",75),
                new Player("MSDhoni",50),
                new Player("SuryaKumar",65)
            };
            Team t = new Team(India);
            foreach(Player p in t)
            {
                Console.WriteLine(p.NAME + " " + p.RUNS);
            }
            
        }
    }
}
