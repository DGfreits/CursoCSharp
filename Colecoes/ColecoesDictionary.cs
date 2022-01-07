using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();  // < ID, VALOR >

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) { // CONSULTA SE TEM O ID
                Console.WriteLine("2004: " + filmes[2004]); // RETORNA O VALOR DO ID "pode dar mensagem de erro se não tiver o ID"
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004)); // RETORNA O VALOR DO ID "sem erro (string vazia)"
            }

            Console.WriteLine(filmes.ContainsValue("Aminésia")); // CONSULTA SE TEM O VALOR

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}"); // REMOVE APARTIR DO ID E RETORNA TRUE OU FALSE

            filmes.TryGetValue(2016, out string filme2016); // TENTA PEGAR UM VALOR ATRAVES DA CHAVE
            Console.WriteLine($"Filme {filme2016}");

            // FORMAS DE PERCORRER O DICTIONARY

            foreach (var chave in filmes.Keys) { // PERCORRE OS IDS
                Console.WriteLine(chave);
            }

            foreach (var chave in filmes.Values) { // PERCORRE OS VALORES
                Console.WriteLine(chave);
            }
             
            foreach (KeyValuePair<int, string> filme in filmes) { // PERCORRE OS IDS E OS VALORES
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}."); // PRECORRE OS IDS E OS VALORES DE UM JEITO MAIS SIMPLES
            }
        }
    }
}
