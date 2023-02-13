using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vstavka
{
    public class Obmene
    {
        public string sorta_obmena(int[] mas)
        {
            string bybod = "";

            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }

            }
            for(int i = 0; i < mas.Length; i++)
            {
                bybod += mas[i] + " ";
            }

            return bybod;
        }
        public string sorta_obmena_down(int[] mas)
        {
            string bybod = "";

            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }

            }
            for (int i = 1; i < mas.Length + 1; i++)
            {
                bybod += mas[mas.Length - i] + " ";
            }

            return bybod;
        }
    }
}
