using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace vstavka
{
    public class Vstavkas
    {
        public string sorta_vstavka(int[] mass)
        {
            string vyvod = "";
            int newElement, location;
            for (int i = 1; i < mass.Length; i++)
            {
                newElement = mass[i];
                location = i - 1;
                while (location >= 0 && mass[location] > newElement)
                {
                    mass[location + 1] = mass[location];
                    location--;
                }
                mass[location + 1] = newElement;
            }
            for(int i = 0; i < mass.Length; i++)
            {
                vyvod += mass[i]+ " ";
            }
                return vyvod;
        }

        public string sorta_vstavka_down(int[] mass)
        {
            string vyvod = "";
            int newElement, location;
            for (int i = 1; i < mass.Length; i++)
            {
                newElement = mass[i];
                location = i - 1;
                while (location >= 0 && mass[location] > newElement)
                {
                    mass[location + 1] = mass[location];
                    location--;
                }
                mass[location + 1] = newElement;
            }
            for (int i = 1; i < mass.Length + 1; i++)
            {
                vyvod += mass[mass.Length - i] + " ";
            }
            return vyvod;
        }

    }
    
 }
