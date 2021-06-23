using System;

class Program 
{
    static void Main(string [] args) 
    
    {
        int ch = 300; //chico
        int be = 1500; //bento
        int br = 600; //bernardo
        int ma = 1000; //marina
        int ia = 150; //iara
        int mr = 225;
        int porcao;
        int i = 1;
        
        while ( i <= 5 )
        {
          porcao = int.Parse(Console.ReadLine());
          if( i == 1 )
          {
            ch *= porcao;
          }
          else if ( i == 2 )
          {
            be *= porcao;
          }
          else if ( i == 3 )
          {
            br *= porcao;
          }
          else if ( i == 4 )
          {
            ma *= porcao;
          }
          else if ( i == 5 )
          {
            ia *= porcao;
          }
          i++;
        }
        
        int total = ch + be + br + ma + ia + mr; // Digite aqui o calculo total
        Console.WriteLine(total);
    }
}
