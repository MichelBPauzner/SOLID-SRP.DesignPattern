﻿using System;

namespace SRP.Solucao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SRP - Solução");
            Informacao informacao = new Informacao();
            Console.WriteLine("Busca alguma informação do banco de dados e loga no event viewer do Windows.");
            informacao.RetornaInformacao();
            Console.WriteLine("Salva alguma informação do banco de dados e loga no event viewer do Windows.");
            informacao.SalvaInformacao();
            Console.ReadKey();
        }
    }
}
