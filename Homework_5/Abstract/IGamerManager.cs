using Homework_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Abstract
{
    public interface IGamerManager
    {
        void Save(Gamer gamer);
        void Update(string nationalId,string name,string lastname, int birthyear);
        void Delete(string nationalId);
        void List();
        Gamer PickGamer(string nationalId);
    }
}
