using System;


class Program
{
    static void Main(string[] args)
    {
        Nation land = new Nation();
        while (land.GetAlive())
        {
            Console.WriteLine("Choose an action, taxes, recruit, kill, stats");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "taxes":
                    Console.WriteLine("balance has been added");
                    land.Taxes();
                    land.Tick();
                    break;
                case "recruit":
                    Console.WriteLine("Whats the name of the person you would like to recruit?");
                    string recruit = Console.ReadLine();
                    land.Recruit(recruit);
                    land.Tick();
                    break;
                case "torture":
                    land.Torture();
                    land.Tick();
                    break;
                case "stats":
                    land.PrintStats();
                    break;
                default:
                    Console.WriteLine("No, just No");
                    break;
            }
        }
    }
}