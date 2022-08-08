using Homework_5.Abstract;
using Homework_5.Entities;
using Homework_5.Adapters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Concrete
{
    public class GamerManager : IGamerManager
    {

        Gamer gamer = new Gamer();
        List<Gamer> gamers = new List<Gamer>();
        MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();
        public void Save(Gamer gamer)
        {
            if (mernisServiceAdapter.GamerCheckService(gamer))
            {
                gamers.Add(gamer);
                Console.WriteLine("Oyuncu eklendi\n");
            }
            else
            {
                Console.WriteLine("Girdiğiniz oyuncu bilgileri ile merniste eşleşen bir kayıt bulunamadı\n");
            }
        }

        public void Update(string nationalId, string name, string lastname, int birthyear)
        {
            int _findIndex = gamers.FindIndex(x => x.NationalId == nationalId);
            gamers[_findIndex].FirstName = name;
            gamers[_findIndex].LastName = lastname;
            gamers[_findIndex].BirthYear = birthyear;
            Console.WriteLine("Oyuncu güncellendi!!");

        }
        public void Delete(string nationalId)
        {
            int _findIndex = gamers.FindIndex(x => x.NationalId == nationalId);
            gamers.Remove(gamers[_findIndex]);
            Console.WriteLine("Oyuncu silindi\n");
        }
        public void List()
        {
            foreach (var i in gamers)
            {
                Console.WriteLine("Oyuncu Adı-Soyadı: " + i.FirstName + "-" + i.LastName + " Kimlik Numarası: " + i.NationalId);
            }
        }
        public Gamer PickGamer(string nationalId)
        {
            Gamer gamer1 = gamers.Find(x => x.NationalId == nationalId);
            return gamer1;
        }
    }
}
