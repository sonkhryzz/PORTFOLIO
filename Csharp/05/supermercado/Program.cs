using System;
using System.Collections.Generic;
using System.Linq;

namespace Compras_No_Supermercado
{
    class Program
    {        
        static void Main(string[] args)
        {
            string[] prods;
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for ( int i = 0; i < n; i++ )
            {
                prods = Console.ReadLine().Split(' ');
                for ( int j = 0; j < prods.Length; j++ )
                {
                    list.Add(prods[j]);
                }
                list.Sort();
                IEnumerable<string> listLimpa = list.AsQueryable().Distinct();
                int a = listLimpa.Count();
                foreach ( var item in listLimpa )
                {

                    if ( a > 1 )
                    {
                        Console.Write($"{item}");
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write($"{item}");
                    }
                    a--;

                }
                list.Clear();
                Console.WriteLine();
            }
        }
    }
}