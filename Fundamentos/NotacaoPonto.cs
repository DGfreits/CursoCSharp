using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo");

            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length); 

            string valorImportante = null;

            Console.WriteLine(valorImportante?.Length); // O "?" faz com que o valor só seja exibido se ele estiver OK
        }
    }
}
