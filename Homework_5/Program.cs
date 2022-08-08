using Homework_5.Entities;
using Homework_5.Concrete;
using System;
using System.Collections.Generic;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();
            Seller seller = new Seller();
        BASLA:
            Gamer gamer1 = new Gamer();
            Game game = new Game();
            Campaign campaign = new Campaign();
            Sell sell = new Sell();

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("1-Oyuncu işlemleri \n" + "2-Oyun işlemleri \n" + "0-Çıkış \n");
            string choice1 = Console.ReadLine();
            #region Oyuncu İşlemleri
            if (choice1 == "1")
            {
            OYUNCUSECIMI:
                Console.WriteLine("Yapmak istediğiniz oyuncu işlemini seçiniz: ");
                Console.WriteLine("1-Oyuncu ekleme \n" + "2-Oyuncu güncelleme \n" + "3-Oyuncu silme \n" + "4-Oyuncunun sahip olduğu oyunları listeleme \n" + "5-Oyuncuları listeleme \n");
                string choice2 = Console.ReadLine();
                if (choice2 == "1")
                {
                    Console.WriteLine("Eklemek istediğiniz oyuncunun kimlik numarasını giriniz: ");
                    gamer1.NationalId = Console.ReadLine();
                    Console.WriteLine("Eklemek istediğiniz oyuncunun adını giriniz: ");
                    gamer1.FirstName = Console.ReadLine();
                    Console.WriteLine("Eklemek istediğiniz oyuncunun soyadını giriniz: ");
                    gamer1.LastName = Console.ReadLine();
                    Console.WriteLine("Eklemek istediğiniz oyuncunun doğum yılını giriniz: ");
                    gamer1.BirthYear = Convert.ToInt32(Console.ReadLine());
                    gamerManager.Save(gamer1);
                }
                else if (choice2 == "2")
                {
                    Console.WriteLine("Update etmek istediğiniz oyuncunun kimlik numarasını giriniz:");
                    string nationalId1 = Console.ReadLine();
                    Console.WriteLine("Update etmek istediğiniz oyuncunun yeni adını giriniz:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Update etmek istediğiniz oyuncunun yeni soyadını giriniz:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Update etmek istediğiniz oyuncunun yeni doğum yılını giriniz: ");
                    int birthYear = Convert.ToInt32(Console.ReadLine());
                    gamerManager.Update(nationalId1, firstName, lastName, birthYear);
                }
                else if (choice2 == "3")
                {
                    Console.WriteLine("Silmek istediğiniz oyuncunun kimlik numarasını giriniz:");
                    string nationalId2 = Console.ReadLine();
                    gamerManager.Delete(nationalId2);
                }
                else if (choice2 == "4")
                {
                    Console.WriteLine("Oyunlarını görmek istediğiniz oyuncunun kimlik numarasını giriniz:");
                    string nationalId3 = Console.ReadLine();
                    Gamer gamer = new Gamer();
                    gamer = gamerManager.PickGamer(nationalId3);
                    if(gamer !=null)
                    seller.GetSellsByGamerId(gamer);
                    else
                    {
                        Console.WriteLine("Girdiğiniz kimlik numarasına sahip bir oyuncu bulunamadı");
                        goto OYUNCUSECIMI;
                    }
                }
                else if (choice2 == "5")
                {
                    gamerManager.List();
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız");
                    goto OYUNCUSECIMI;
                }
            }
            #endregion
            #region Oyun İşlemleri
            else if (choice1 == "2")
            {
                OYUNSECIMI:
                Console.WriteLine("Yapmak istediğiniz oyun işlemini seçiniz: ");
                Console.WriteLine("1-Oyun ekleme\n"  + "2-Oyun silme \n" + "3-Oyuna sahip olan oyuncuları listeleme \n" + "4-Oyun satma \n" + "5-Oyunları listele \n");
                string choice3 = Console.ReadLine();
                if (choice3 == "1")
                {
                    Console.WriteLine("Eklemek istediğiniz oyunun adını yazınız: ");
                    string gameName = Console.ReadLine();
                    game.GameName = gameName;
                    Console.WriteLine("Eklemek istediğiniz oyunun barkod numarasını yazınız: ");
                    int gameId = Convert.ToInt32(Console.ReadLine());
                    game.Id = gameId;
                    gameManager.SaveGame(game);
                }
                else if (choice3 == "2")
                {
                    Console.WriteLine("Silmek istediğiniz oyunun barkod numarasını yazınız: ");
                    int gameId = Convert.ToInt32(Console.ReadLine());
                    gameManager.RemoveGame(gameId);
                }
                else if (choice3 == "3")
                {
                    Console.WriteLine("Görüntülemek istediğiniz oyunun barkod numarasını yazınız: ");
                    int gameId = Convert.ToInt32(Console.ReadLine());
                    Game game1 = new Game();
                    game1 = gameManager.PickGame(gameId);
                    seller.GetSellsByGameId(game1);
                }
                else if (choice3 == "4")
                {
                    Console.WriteLine("Oyunlar: ");
                    gameManager.List();
                    gamerManager.List();
                    campaignManager.List();
                    Console.WriteLine("Satmak istediğiniz oyunun barkod numarasını yazınız: ");
                    int gameId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Alıcı kimlik numarasını giriniz: ");
                    string gamerNationalId = Console.ReadLine();
                    Console.WriteLine("Yararlanmak istediğiniz kampanya numarasını yazınız: ");
                    int campaignId = Convert.ToInt32(Console.ReadLine());
                    Game game1 = new Game();
                    game1 = gameManager.PickGame(gameId);
                    Gamer gamer = new Gamer();
                    gamer = gamerManager.PickGamer(gamerNationalId);
                    Campaign campaign1 = new Campaign();
                    campaign1 = campaignManager.PickCampaign(campaignId);
                    seller.AddSell(game1,gamer,campaign1);
                }
                else if (choice3 == "5")
                {
                    gameManager.List();
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız");
                    goto OYUNSECIMI;
                }
            }
            else if (choice1 == "0")
            {
                Environment.Exit(0);
            }
            #endregion
            else
            {
                Console.WriteLine("Lütfen geçerli bir seçim yapınız");
                goto BASLA;
            }
            goto BASLA;



        }

    }
}
