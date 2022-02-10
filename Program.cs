using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // FUNDAMENTOS
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fudamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fudamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fudamentos", Inferencia.Executar},
                {"Interpolação de String - Fudamentos", Interpolacao.Executar},
                {"Notação Ponto - Fudamentos", NotacaoPonto.Executar},
                {"Lendo Dados do Console - Fudamentos", LendoDados.Executar},
                {"Formatando Números - Fudamentos", FormatandoNumeros.Executar},
                {"Conversões - Fudamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fudamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fudamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos #1 - Fudamentos", OperadoresLogicos1.Executar},
                {"Operadores de Atribuição - Fudamentos", OperadorAtribuicao.Executar},
                {"Operadores Unários - Fudamentos", OperadoresUnarios.Executar},
                {"Operador Ternári - Fudamentos", OperadorTernario.Executar},

                // ESTRUTURA DE CONTROLE
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ELSE/IF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura SWITH - Estruturas de Controle", EstruturaSwith.Executar},
                {"Estrutura WHILE - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura DO WHILE - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura FOR - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura FOREACH - Estruturas de Controle", EstruturaForeach.Executar},
                {"Break - Estruturas de Controle", Break.Executar},
                {"Continue - Estruturas de Controle", Continue.Executar},


                // CLASSE E MÉTODOS 
                {"Membros - Calasses e Métodos", Membros.Executar},
                {"Construtores - Calasses e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Calasses e Métodos", MetodosComRetorno.Executar},
                {"Método Statico - Calasses e Métodos", MetodosStaticos.Executar},
                {"Atributos Staticos - Calasses e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Calasses e Métodos", DesafioAtributos.Executar},
                {"Parâmetros Variáveis - Calasses e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Calasses e Métodos", ParametrosNomeados.Executar},
                {"Get and Set - Calasses e Métodos", GetSet.Executar},
                {"Props - Calasses e Métodos", Props.Executar},
                {"Readonly - Calasses e Métodos", Readonly.Executar},
                {"Exemplo Enum - Calasses e Métodos", ExemploEnum.Executar},
                {"Struct - Calasses e Métodos", ExemploStruct.Executar},
                {"Struct vs Classe - Calasses e Métodos", StructVsClasse.Executar},
                {"Valor vs Referência - Calasses e Métodos", ValorVsReferencia.Executar},
                {"Parametros por Referência - Calasses e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Calasses e Métodos", ParametroPadrao.Executar},
                

                // COLEÇÕES
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Coleções Stack - Coleções", ColecoesStack.Executar},
                {"Coleções Dictionary - Coleções", ColecoesDictionary.Executar},


                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
            });
             
            central.SelecionarEExecutar();
        }
    }
}