using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {

            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.234; NÃO ANTERA PQ ESSA VAIÁVEL É UMA CONSTANTE "const"

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45; // byte = sem sinal ------ sbyte = com sinal
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // MinValue = exibe o menor valor possível
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue; // MaxValue = exibe o maior valor possível
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // int = com sinal ------ uint = sem sinal
            Console.WriteLine("Menor valor inteiro " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue; // long = com sinal ------ ulong = sem sinal
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de Mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Dinstancia entra as estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja vem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
