using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumeros {
        public static void Executar() {

            /* Funções para formatação do número
             *
             * "F" modifica as casas decimais
             * "C" transforma em valor monetario 
             * "P" valor percentual %
             * "#.##" tipo de formatção mais especifica
             * "D10" quantos 0 devem aparecer a esquerda
             */

            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            // Define a moeda que será usada
            CultureInfo cultura = new CultureInfo("en-US");

            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
