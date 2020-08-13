using System;
using MacEFConsoleApp.Entities;

namespace MacEFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ActorDBContext())
            {
                db.Actors.AddRange(new Actor{Name = "Maurilio", Age=35, AcademyWinner=false},
                                    new Actor{Name="Vanessa", Age=32, AcademyWinner=true});
                var count = db.SaveChanges();

                Console.WriteLine("{0} adocional register to database", count);
                Console.WriteLine();
                Console.WriteLine("All Actors in DB");

                foreach (var Actor in db.Actors)
                {
                    Console.WriteLine($"Bame = {Actor.Name}, \t\t" +
                                      $"Age: {Actor.Age}, \t\t" +
                                      $"Academy Winner: {Actor.AcademyWinner}");
                }
                
            }
        }
    }
}
