using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraStatica {
        // Método de Classe ou Método estático!!!
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // Método de instância!!!
        public int Somar(int a, int b) {
            return a + b;
        }
    }
    internal class MetodosStaticos {
        public static void Executar() {
            var resultado = CalculadoraStatica.Multiplicar(2, 2);
            Console.WriteLine(resultado);

            CalculadoraStatica calc = new CalculadoraStatica();

            Console.WriteLine(calc.Somar(2, 3));
        }
    }
}
