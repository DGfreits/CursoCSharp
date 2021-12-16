using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; 
            // QUANDO A POSSIBILIDADE DE PERDER INFORMAÇÃO
            Console.WriteLine("Nota Truncada: " + notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse (idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o 1 número:");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("O numero é: " + numero);

            Console.Write("Digite o 2 número:");
            int.TryParse(Console.ReadLine(), out int numero2); 
            // QUANDO LER ALGUMA COISA QUE NÃO SEJA UM NÚMERO O RESULTADO VAI SER 0
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
