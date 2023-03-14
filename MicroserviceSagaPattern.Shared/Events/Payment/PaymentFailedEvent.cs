﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceSagaPattern.Shared.Events.Payment
{
    public class PaymentFailedEvent
    {
        public int OrderId { get; set; }
        public string BuyerId { get; set; }
        public string Description { get; set; }
    }
}