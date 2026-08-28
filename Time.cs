using System;
using System.Collections.Generic;
using System.Text;

namespace abstracao
{
    public class Time
    {
        public string NomeTime;
        public List<Jogador> ListaJogadores = [];

        public void AdicionarJogador(Jogador jogador)
        {
            ListaJogadores.Add(jogador);
        }

        public void ListarJogadores()
        {
            Console.WriteLine($"A escalação do time {NomeTime}: ");
            foreach (var jogador in ListaJogadores)
            {
                Console.WriteLine($"--------------------\nJogador: {jogador.Nome}\nPosição: {jogador.Posicao}\nNúmero do Jogador: {jogador.NumeroCamisa}\n--------------------");
            }
        }
    }
}