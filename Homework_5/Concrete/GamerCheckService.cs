using Homework_5.Abstract;
using Homework_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Concrete
{
    public class GamerCheckService : IGamerCheckService
    {
        bool IGamerCheckService.GamerCheckService(Gamer gamer)
        {
            return true;
        }
    }
}
