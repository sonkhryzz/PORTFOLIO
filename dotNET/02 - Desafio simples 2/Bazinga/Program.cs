using System; 

class Program 
{

    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            const string ts = "tesoura";
            const string pp = "papel";
            const string pd = "pedra";
            const string lg = "lagarto";
            const string sp = "Spock";
            for (int i = 1; i <= qtdTeste; i++) 
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];
                if(( v1 == ts && v2 == pp ) 
                || ( v1 == pp && v2 == pd ) 
                || ( v1 == pd && v2 == lg ) 
                || ( v1 == lg && v2 == sp )
                || ( v1 == sp && v2 == ts ) 
                || ( v1 == ts && v2 == lg )
                || ( v1 == lg && v2 == pp ) 
                || ( v1 == pp && v2 == sp )
                || ( v1 == sp && v2 == pd ) 
                || ( v1 == pd && v2 == ts ))
                {
                Console.WriteLine("Caso #{0}: Bazinga!", i); 
                }
                    
                else if ( v1.ToString() == v2.ToString() ) 
                {
                    Console.WriteLine("Caso #{0}: De novo!", i);
                }
                else
                {
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
                }
            }

    }

}