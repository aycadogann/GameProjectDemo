using GameProjectDemo.Abstract;
using GameProjectDemo.Adapters;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerCheckService gamerCheckService = new MernisServiceAdapter();
            IGamerService gamerService = new GamerManager(gamerCheckService);
            Gamer gamer =new Gamer(){ 
                DateOfBirth = new DateTime(1996, 2, 12), Name = "Ayça", 
                LastName = "Doğan", NationalityId = "11111111111" };
            gamerService.Add(gamer);


            Campaign campaign = new Campaign()
            {
                CampaignName = "Sonbahar",
                Discount = 10
            };
            ICampaignService campaignService = new CampaignManager();
            campaignService.Update(campaign);


            Sale sale = new Sale() { Price = 150 };
            ISaleService saleService = new SaleManager();
            saleService.Sale(gamer, campaign, sale);


            Console.ReadLine();
        }
    }
}
