using Homework_5.Abstract;
using Homework_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Concrete
{
    class GameManager : IGameManager
    {
        List<Game> games = new List<Game>();
        public void SaveGame(Game game)
        {
            games.Add(game);
            Console.WriteLine("Oyun eklendi\n");
        }

        public void RemoveGame(int gameId)
        {
            int _findIndex = games.FindIndex(x => x.Id == gameId);
            games.Remove(games[_findIndex]);
            Console.WriteLine("Oyun silindi\n");

        }
        public List<Game> List()
        {
            foreach(var i in games)
            {
                Console.WriteLine("Oyun: "+i.GameName + " Barkod Numarası: " + i.Id);
            }
            return games;
        }
        public Game PickGame(int gameId)
        {
            Game game1 = games.Find(x => x.Id == gameId);
            return game1;
        }


    }
}
