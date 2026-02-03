using IO5Plan.Strategies.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO5Plan.Strategies.Menu
{
    public class ShowGenetaredPlansStrategy : IMenu
    {
        public void Show()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Wyświetlanie wygenerowanych planów lekcji");

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Podaj nazwę klasy, dla której chcesz wyświetlić wygenerowane plany lekcji:");

            string className = Console.ReadLine();

            Console.WriteLine($"Wyświetlanie wygenerowanych planów lekcji dla klasy {className}...");

            Console.WriteLine("Tu bedzie logika do wyświetlania wyugenerowanych planów");

            Console.WriteLine("Wygenerowane plany lekcji zostały pomyślnie wyświetlone.");
        }
    }
}
