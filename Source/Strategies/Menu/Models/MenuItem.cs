using IO5Plan.Strategies.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO5Plan.Strategies.Menu.Models
{
    public class MenuItem 
    {
       public string MenuMessage { get; set; }
       public int MenuNumber { get; set; }
       public IMenu Menu { get; set; }

        public override string ToString()
        {
            return $"{MenuNumber} - {MenuMessage}";
        }
    }
}
