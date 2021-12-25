using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento; // CRIA UM VALOR IMUTAVEL DURANTE O CODIGO 
        const int x = 1; // CRIA UM VALOR IMUTAVEL QUE PRECISA SER INICIALIZADO ANTES DE EXECUTAR O CODIGO

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    internal class Readonly {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1997, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}
