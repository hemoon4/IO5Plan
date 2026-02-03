namespace IO5Plan;

using IO5Plan.Strategies.Menu;
using System;
class Program
{
    static void Main(string[] args)
    {
        var mainMenu = new MainMenuStrategy();
        Console.WriteLine("Witaj w IO5Plan!");
        mainMenu.Show();
    }
}