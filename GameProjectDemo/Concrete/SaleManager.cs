using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        double _discount;
        double _price;

        public void Sale(Gamer gamer, Campaign campaign, Sale sale)
        {
            _discount = (sale.Price * campaign.Discount) / 100;
            _price = sale.Price - _discount;

            Console.WriteLine("{0} oyunu {1} TL aldı.", gamer.Name, _price);
        }
    }
}
