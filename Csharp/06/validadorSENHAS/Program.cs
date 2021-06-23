using System;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string senha;

            while ( !string.IsNullOrEmpty(senha = Console.ReadLine()) )
            {
                var contMinusculo = Regex.Matches(senha, "[a-z]").Count;
                var contMaiusculo = Regex.Matches(senha, "[A-Z]").Count;
                var contNumero = Regex.Matches(senha, "[0-9]").Count;

                if ( senha.Length >= 6
                  && senha.Length <= 32
                  && contMinusculo > 0
                  && contMaiusculo > 0
                  && contNumero > 0
                  && ( contMinusculo + contMaiusculo + contNumero == senha.Length ) )
                {
                    Console.WriteLine("Senha valida.");
                }
                else
                {
                    Console.WriteLine("Senha invalida.");
                }
            }
        }
    }


