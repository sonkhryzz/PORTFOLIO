using System;

namespace SNKseasons
{
    public class Games : EntidadeBase
    {
        private Genero Genre { get; set;}
        private string Title { get; set;}
        private string About { get; set;}
        private int Year { get; set;}
        private bool Erased { get; set; }

    
        public Games(int id, Genero Genre, string Title, string About, int Year)
        {
            this.Id = id;
            this.Genre = Genre;
            this.Title = Title;
            this.About = About;
            this.Year = Year;
            this.Erased = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genre: " + this.Genre + Environment.NewLine;
            retorno += "Title: " + this.Title + Environment.NewLine;
            retorno += "About: " + this.About + Environment.NewLine;
            retorno += "Year: " + this.Year + Environment.NewLine;
            retorno += "Eresed: " + this.Erased;
            return retorno;
        }

        public string returnTitle()
        {
            return this.Title;
        }

        public int returnTHEId()
        {
            return this.Id;
        }

        public bool returnErased()
		{
			return this.Erased;
		}

        public void Eraser() {
            this.Erased = true;
        }

    }
}    