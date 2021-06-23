using System;
using System.Globalization;

namespace Programa_Para_Validacao_De_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a, b;
            int nv = 0;
            bool chec = true;

            do
            {
                a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if ( a <= 10 && a >= 0 )//verifica se nota dentro dos parametros
                {
                    do
                    {
                        nv = 0;
                        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        if ( b <= 10 && b >= 0 )//verifica se nota dentro dos parametros
                        {
                            r = ( a + b ) / 2;
                            Console.WriteLine($"media = {r.ToString("F2", CultureInfo.InvariantCulture)}");
                            do
                            {
                                Console.WriteLine("novo calculo (1-sim 2-nao)");
                                nv = int.Parse(Console.ReadLine());
                                if ( nv == 2 )
                                {
                                    nv = 1;
                                    chec = false;
                                }

                            } while ( nv != 1 );

                        }
                        else
                        {
                            Console.WriteLine("nota invalida");
                        }

                    } while ( nv != 1 );
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

            } while ( chec != false );
        }
    }
}
