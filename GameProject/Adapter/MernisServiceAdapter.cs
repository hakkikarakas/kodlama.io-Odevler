using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapter
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {   

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(gamer.NationalityId),
                    gamer.FirstName,
                    gamer.LastName,
                    gamer.DateOfBirth.Year
                    ))
                ).Result.Body.TCKimlikNoDogrulaResult;
        
        }
    }
}
