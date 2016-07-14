﻿using System;
using System.Collections.Generic;

namespace ReflectionAccessor.Tests.Models
{
    public class Order
    {
        public string Id { get; set; }

        public int OrderNumber { get; set; }

        public Contact Contact { get; set; }

        public MailingAddress ShippingAddress { get; set; }

        public MailingAddress BillingAddress { get; set; }

        public List<OrderLine> Items { get; set; }

        public decimal Total { get; set; }
    }
}