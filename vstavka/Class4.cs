using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vstavka
{
    public class generate
    {
        public int[] genMethod()
        {
            int[] massiv = new int[10];
            Random random = new Random();
            for(int i = 0; i < massiv.Length; i++) massiv[i] = random.Next(0, 100);
            return massiv;
        }
    }
}
