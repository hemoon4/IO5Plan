using IO5Plan.Strategies.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO5Plan.Strategies.Menu
{
    public class ExitMenuStrategy:IMenu
    {
        public void Show()
        {
            Console.WriteLine("Dziękujemy za skorzystanie IO5Plan. Do zobaczenia!");
        }
    }
}
