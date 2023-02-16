using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEste.FichaPersonagem
{
    public class Combate
    {    
        public Combate()
        {

        }
        public void Combat(Player play1,Player play2, int atkp1,int atkp2)
        {           
            int dnvida1 = atkp1 - atkp2;
            int dnvida2 = atkp2 - atkp1;

            if ((atkp1 != null) && (atkp2 != null))
            {
                if (atkp1 > atkp2)
                {
                    play2.Vida = play2.Vida - dnvida1;                    
                }
                else if (atkp2 > atkp1)
                {
                    play1.Vida = play1.Vida - dnvida2;                   
                }               
            }
        }
    }
}
