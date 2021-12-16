﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fudamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fudamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fudamentos", Inferencia.Executar},
                {"Interpolação de String - Fudamentos", Interpolacao.Executar},
                {"Notação Ponto - Fudamentos", NotacaoPonto.Executar},
                {"Lendo Dados do Console - Fudamentos", LendoDados.Executar},
            });
             
            central.SelecionarEExecutar();
        }
    }
}