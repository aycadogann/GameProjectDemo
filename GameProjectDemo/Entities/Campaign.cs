﻿using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Entities
{
    public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double Discount { get; set; }
    }
}
