using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Entities
{
    public class Sale:IEntity
    {
        public int SaleId { get; set; }
        public double Price { get; set; }
    }
}
