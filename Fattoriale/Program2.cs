using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoriale
{
    public class Program1
    {
        static public long Fattoriale(long N1)
        {
            long fattoriale = 1;

            for (int i = 1; i <= N1; i++)
            {
                fattoriale = fattoriale * i;
            }

            return fattoriale;
        }
    }
}