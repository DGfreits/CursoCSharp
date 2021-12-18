using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class Continue {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("Números pares entre 1 e {0}", intervalo);

            for (int i = 0; i < intervalo; i++) {
                if (i % 2 == 1) {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
