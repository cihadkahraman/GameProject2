using Homework_5.Abstract;
using Homework_5.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool GamerCheckService(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
