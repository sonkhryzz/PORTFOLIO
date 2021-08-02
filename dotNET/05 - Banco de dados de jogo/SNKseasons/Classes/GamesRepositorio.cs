using System;
using System.Collections.Generic;
using SNKseasons.Interfaces;

namespace SNKseasons
{
    public class GamesRepositorio : IRepositorio<Games>
    {
        private List<Games> listGames = new List<Games>();
        public void Change(int id, Games entidade)
        {
            listGames[id] = entidade;
        }

        public void Erase(int id)
        {
            listGames[id].Eraser();
        }

        public void Insert(Games entidade)
        {
            listGames.Add(entidade);
        }

        public List<Games> List()
        {
            return listGames;
        }

        public int NextId()
        {
            return listGames.Count;
        }

        public Games ReturnId(int id)
        {
            return listGames[id];
        }
    }
}