using IO5Plan.Strategies.Menu.Interfaces;
using IO5Plan.Strategies.Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO5Plan.Strategies.Menu
{
    public class MainMenuStrategy:BaseMenuStrategy,IMenu
    {
        public override string MenuMessage { get; set; } = "MENU GŁÓWNE:";
        public override IList<Models.MenuItem> MenuItems { get; set; } = [
        new MenuItem {MenuMessage="Wprowadź dane wejściowe", MenuNumber=1,Menu=new ImportDataStrategy() },
        new MenuItem {MenuMessage="Wygeneruj plany lekcji", MenuNumber=2,Menu=new GeneratePlansStrategy() },
        new MenuItem {MenuMessage="Wyświetl wygenerowane plany", MenuNumber=3, Menu=new ShowGenetaredPlansStrategy()},
        new MenuItem {MenuMessage="Zapisz wybrany plan do pliku", MenuNumber=4, Menu = new SaveSelectedPlanStrategy()},
        new MenuItem {MenuMessage="Wyjście", MenuNumber=0, Menu= new ExitMenuStrategy() },
        ];
    }
}
