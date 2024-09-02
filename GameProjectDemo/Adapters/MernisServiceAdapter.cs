using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.Name.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
