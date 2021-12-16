using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos1 {
        public static void Executar() {
            var executouOTrabalho1 = true;
            var executouOTrabalho2 = false;

            var comprouTv50 = executouOTrabalho1 && executouOTrabalho2;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTv50);

            var comprouSorvete = executouOTrabalho1 || executouOTrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouOTrabalho1 ^ executouOTrabalho2;
            Console.WriteLine("Comprou TV 32? {0}", comprouTv32);

            Console.WriteLine("Mais saldável? {0}", !comprouSorvete);
        }
    }
}
