using IO5Plan.Strategies.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO5Plan.Strategies.Menu
{
    public class SaveSelectedPlanStrategy : IMenu
    {
        public void Show()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Zapisywanie wybranego planu");

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Plany dla której klasy chcesz wyświetlić?");

            string className = Console.ReadLine();

            Console.WriteLine("Wyświetlanie wygenerowanych planów lekcji dla klasy " + className + "...");

            Console.WriteLine("Ktory plan chcesz zapisać do pliku, podaj jego numer.");

            string planNumber = Console.ReadLine();

            Console.WriteLine("Podaj nazwę pliku do zapisu planu lekcji:");

            string fileName = Console.ReadLine();

            Console.WriteLine("Zapisywanie planu lekcji do pliku: " + fileName + "...");

            Console.WriteLine("Plan lekcji został pomyślnie zapisany.");
        }
    }
}
