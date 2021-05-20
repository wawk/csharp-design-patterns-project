using System;

namespace csharp_design_patterns_project
{
    class Program
    {
        static void Main(string[] args)
        {
           PrimaryPlayer player = PrimaryPlayer.Instance;
           Console.WriteLine($"{player.Name} -lvl {player.Level}");
            Console.ReadKey(); ;
        }

    }
}
