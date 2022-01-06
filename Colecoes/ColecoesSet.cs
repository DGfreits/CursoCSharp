﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    internal class ColecoesSet {
        public static void Executar() {

            // HASHSET NÃO ACEITA REPETIÇÃO OU DUPLICAÇÃO DE ITENS

            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8 Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo); // ALTERA O CARRINHO PARA SER A UNIÃO
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3); 

            foreach (var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            //Console.WriteLine(carrinho.LastIndexOf(livro));
            
        }
    }
}
