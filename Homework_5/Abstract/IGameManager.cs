using System;
using System.Collections.Generic;
using System.Text;
using Homework_5.Entities;

namespace Homework_5.Abstract
{
    public interface IGameManager
    {
        void SaveGame(Game game);
        void RemoveGame(int gameId);
        List<Game> List();
        Game PickGame(int gameId);
    }
}
