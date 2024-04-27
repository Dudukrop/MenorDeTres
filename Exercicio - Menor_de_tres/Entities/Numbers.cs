using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Menor_de_tres.Entities
{
    class Numbers
    {

        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }

        public Numbers(int n1, int n2, int n3)
        {
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }

        public int Menor()
        {
            if (N1 <= N2 && N1 <= N3)
                return N1;

            else if (N2 <= N3)
                return N2;

            else
                return N3;
        }

        public override string ToString()
        {
            return "Menor = "
                + Menor();
        }
    }
}
