using System;
using System.Collections.Generic;

public class Nation
{
    public string name;
    private int balance;
    private int unsatisfaction;
    private bool isAlive = true;
    private List<string> recruits = new List<string>() { "Bob", "Almud" };
    private Random rnd = new Random();
    public Nation()
    {
        Console.WriteLine("A great Nation deserves a good name, what will you choose?");
        this.name = Console.ReadLine();
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    public void Recruit(string recruit)
    {
        recruits.Add(recruit);
        Console.WriteLine($"Succesfully recruited {recruit} to dictionary OvO");
        ReduceUnsatisfaction();
    }
    public void Torture()
    {
        int index = rnd.Next(recruits.Count);
        Console.WriteLine(recruits[index]);
        ReduceUnsatisfaction();
    }
    public void Taxes()
    {
        balance += 8;
        balance = Math.Max(0, balance);
    }

    public void Tick()
    {
        unsatisfaction--;
        balance--;
        if (balance < 0 || unsatisfaction < 0)
            isAlive = false;
    }
    public void PrintStats()
    {
        Console.WriteLine("Our name is" + name);
        Console.WriteLine($"Our balance is {balance} ");
        Console.WriteLine($"The People are {unsatisfaction} satisfied");
    }
    private void ReduceUnsatisfaction()
    {
        unsatisfaction += 5;
        unsatisfaction = Math.Max(0, unsatisfaction);
    }
}