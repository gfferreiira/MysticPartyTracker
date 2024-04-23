using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Model
{
    public class Dice
    {
        public Dice()
        {
        }

        public Dice(int side)
        {
            Side = side;
        }
       

        public int Side { get; set; }
        public int Rolar()
        {
            //Retorna o valor da rolagem do dado.
            return new Random().Next(1, Side + 1);
        }
    

    }
}
