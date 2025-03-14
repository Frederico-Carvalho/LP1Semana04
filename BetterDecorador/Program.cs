﻿using System;

namespace BetterDecorador
{
    /// <summary>
    /// O programa serve para decorar uma string dada cercando-a com um caracter repetido.
    /// Se nao forem dados nenhuns argumentos, será dado uma mensagem padrão
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Inicio do program, onde se analisa argumentos de linha, de comando e chama o método Decor apropriado.
        /// </summary>
        /// <param name="args">
        /// Um array de strings contém:
        /// args[0] - O texto a ser decorado.
        /// args[1] - Um unico caracter a ser usado para o decorator.
        /// args[2] - Um integer especificando quantas vezes o caracter decorator deveria repetir.
        /// Se nao forem dados nenhuns argumentos, será dado uma mensagem padrão
        /// </param>
        private static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine(Decor());
                return;
            }

            string text = args[0];
            char decorator;
            int repeat;

            if (!char.TryParse(args[1], out decorator))
            {
                return;
            }

            if (!int.TryParse(args[2], out repeat) || repeat < 0)
            {
                return;
            }

            Console.WriteLine(Decor(text, decorator, repeat));
        }

      
        private static string Decor(string s, char dec, int count)
        {
            string decoration = new string(dec, count);
            return $"{decoration} {s} {decoration}";
        }

        /// <summary>
        /// Retorna uma decorated message normal quando não são apresentados argumentos. 
        /// </summary>
        /// <returns>Uma string padrão formatada</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}