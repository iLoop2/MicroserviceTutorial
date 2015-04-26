﻿using Web.Messaging;

namespace Web.Messages
{
    public class ItemAddedToCart : Message
    {
        public string MaterialNumber { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
