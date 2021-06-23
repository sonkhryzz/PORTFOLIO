using System;
using System.Globalization;

namespace coxinhaDEbueno
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int qtdParticipantes = int.Parse(s[0]);
            int qtdCoxinhas = int.Parse(s[1]);
            double media = ( double ) qtdParticipantes / qtdCoxinhas;

            Console.WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}