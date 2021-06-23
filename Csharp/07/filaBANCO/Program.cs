using System;
using System.Collections;
using System.Collections.Generic;

namespace filaBANCO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] notas;
            int qtdEntradas;
            int numReordem = 0;
            List<int> list = new List<int>();
            
            for ( int i = 0; i < n; i++ )
            {
                qtdEntradas = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                notas = new int[qtdEntradas];
                for ( int j = 0; j < qtdEntradas; j++ )
                {
                    notas[j] = int.Parse(s[j]);
                    list.Add(notas[j]);

                    if ( j == ( qtdEntradas - 1 ) )
                    {
                        list.Sort();
                        list.Reverse();
                        for ( int k = 0; k < list.Count; k++ )
                        {
                            if ( notas[k] == list[k] )
                            {
                                numReordem++;
                            }
                        }

                    }                   
                }
                Console.WriteLine(numReordem);
                numReordem = 0;
                list.Clear();
            }
        }
    }
}
