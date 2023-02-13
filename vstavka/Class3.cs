using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vstavka
{
    public class Vybore
    {
        public string sorta_vybora(int[] masss)
        {
            string dydod = "";
            for (int i = 0; i < masss.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < masss.Length; j++)
                {
                    if (masss[j] < masss[min]) min = j;
                }
                int temp = masss[min];
                masss[min] = masss[i];
                masss[i] = temp;
            }

            for(int i = 0; i < masss.Length; i++)
            {
                dydod += masss[i] + " ";
            }
            return dydod;
        }
        public string sorta_vybora_down(int[] masss)
        {
            string dydod = "";
            for (int i = 0; i < masss.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < masss.Length; j++)
                {
                    if (masss[j] > masss[min]) min = j;
                }
                int temp = masss[min];
                masss[min] = masss[i];
                masss[i] = temp;
            }

            for (int i = 0; i < masss.Length; i++)
            {
                dydod += masss[i] + " ";
            }
            return dydod;
        }
    }
}
