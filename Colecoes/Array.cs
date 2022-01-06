using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Array {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Douglas";
            alunos[1] = "jão";
            alunos[2] = "tia";
            alunos[3] = "ladrão";
            alunos[4] = "teste";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double [] notas = { 9.2, 4.8, 8.4, 8.2, 6.8};

            foreach (var nota in notas) {
                somatorio += nota;
            }

            //for (int i = 0; i < notas.Length; i++) {
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'R', 'R', 'A', 'Y' };
            string palavra = new string (letras);
            Console.WriteLine(palavra);
        }
    }
}