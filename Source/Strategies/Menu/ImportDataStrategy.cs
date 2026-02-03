using IO5Plan.Strategies.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO5Plan.Strategies.Menu
{
    public class ImportDataStrategy : IMenu
    {
        public void Show()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Importowanie danych");

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Podaj ścieżkę do pliku z danymi:");

            string filePath = Console.ReadLine();

            Console.WriteLine("Importowanie danych z pliku: " + filePath + "...");

            Console.WriteLine("Dane zostały pomyślnie zaimportowane.");
        }
    }
}
