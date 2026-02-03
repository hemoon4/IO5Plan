using IO5Plan.Strategies.Menu.Interfaces;
using IO5Plan.Strategies.Menu.Models;

namespace IO5Plan.Strategies.Menu
{
    public abstract class BaseMenuStrategy : IMenu
    {
        public abstract IList<MenuItem> MenuItems { get; set; }
        public abstract string MenuMessage { get; set; }
        public void Show()
        {
            bool isOver = false;
            while (!isOver)
            {
                showMainMenuDetails();
                int choise = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                var selectedMenuItem = MenuItems.FirstOrDefault(item => item.MenuNumber == choise);

                if (selectedMenuItem != null)
                {
                    selectedMenuItem.Menu.Show();
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Niepoprawny wybór");
                    Console.WriteLine("");
                }
                if (choise==0)
                {
                    isOver = true;
                }
            }
        }
        private void showMainMenuDetails()
        {
            Console.WriteLine(MenuMessage);
            foreach (var item in MenuItems)
            {
                Console.WriteLine(item.ToString());
            }
            Console.Write("Wybierz opcję: ");
        }
    }
}

