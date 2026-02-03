using IO5Plan.Strategies.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO5Plan.Strategies.Menu
{
    public class GeneratePlansStrategy : IMenu
    {
        public void Show()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Generowanie planów");

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Podaj dla której klasy chcesz wygenerować plany lekcji:");

            string className = Console.ReadLine();

            Console.WriteLine("Podaj liczbę przykładowych planów do wygenerowania:");

            string plansCountInput = Console.ReadLine();

            Console.WriteLine($"Generowanie {plansCountInput} planów lekcji dla klasy {className}...");

            Console.WriteLine("Plany lekcji zostały pomyślnie wygenerowane.");
        }
    }
}
