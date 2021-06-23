using System;
using System.Globalization;

class Program 
{
    static void Main(string [] args) 
    {
      double r;
      
        int n = int.Parse(Console.ReadLine());
       
        for ( int i = 0; i < n ; i++ ) 
        {
            string[] s = Console.ReadLine().Split();
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);
            
            if (y == 0) 
            {
                Console.WriteLine("divisao impossivel");
            } 
            else 
            {
                r = ( double ) x / y; // Digite aqui o calculo da divisao
                Console.WriteLine($"{r. ToString("N1")}");
            }
        }
    }
}