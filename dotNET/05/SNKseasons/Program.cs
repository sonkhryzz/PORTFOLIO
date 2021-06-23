using System;

namespace SNKseasons
{
    class Program
    {
        static GamesRepositorio repositorio = new GamesRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
				{
					case "1":
						ListarGames();
						break;
					case "2":
						InserirGames();
						break;
					case "3":
						AtualizarGames();
						break;
					case "4":
						ExcluirGames();
						break;
					case "5":
						VisualizarGames();
						break;
					case "C":
						Console.Clear();
						break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();                     
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Thanks for for choosing OUR services!!!");
            Console.ReadLine();
        }

        private static void ExcluirGames()
		{
			Console.Write("Type the Game's id: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Erase(indiceSerie);
		}

        private static void VisualizarGames()
		{
			Console.Write("Type the game's id: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.ReturnId(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarGames()
		{
			Console.Write("Type the game's id: ");
			int indiceGames = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("To choose the genre type one of the options above: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Type the game's Title: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Type the game's Year: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Type the game's About: ");
			string entradaDescricao = Console.ReadLine();

			Games atualizaGames = new Games(id: indiceGames,
										Genre: (Genero)entradaGenero,
										Title: entradaTitulo,
										Year: entradaAno,
										About: entradaDescricao);

			repositorio.Change(indiceGames, atualizaGames);
		}
        private static void ListarGames()
		{
			Console.WriteLine("List Games");

			var lista = repositorio.List();

			if (lista.Count == 0)
			{
				Console.WriteLine("No Game data found.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.returnErased();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.returnTHEId(), serie.returnTitle(), (excluido ? "*Erased*" : ""));
			}
		}

        private static void InserirGames()
		{
			Console.WriteLine("Insert new game");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("To choose the genre type one of the options above:  ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Type the game's Title: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Type the game's year: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Type the game's About: ");
			string entradaDescricao = Console.ReadLine();

			Games newGame = new Games(id: repositorio.NextId(),
										Genre: (Genero)entradaGenero,
										Title: entradaTitulo,
										Year: entradaAno,
										About: entradaDescricao);

			repositorio.Insert(newGame);
		}






        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("SNKseasons, the LUDOFLIX's data base!");
            Console.WriteLine("Inform your choice: ");
            Console.WriteLine();
            Console.WriteLine("1. List Games");
            Console.WriteLine("2. Insert New Game data");
            Console.WriteLine("3. Change Game data");
            Console.WriteLine("4. Erase Game data");
            Console.WriteLine("5. View About Game");
            Console.WriteLine("C. Clear Screen");
            Console.WriteLine("X. Exit");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario; 
        }
    }
}
