using System;
class Project
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] rows = {" | | ", " | | ", " | | "};
            string player1 = "o";
            string player2 = "x";
            Console.WriteLine("Player1 is O, Player2 is X");
            Console.WriteLine("--------------------------");
            foreach (string item in rows)
            {
                Console.WriteLine(item)
            }
            Console.WriteLine("j")
        }
    }
}