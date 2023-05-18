using Onis.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onis.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public CatalogItemOrdered ItemOrdered { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Units { get; private set; }

#pragma warning disable CS8618 // Required by Entity Framework
        private OrderItem() { }

        public OrderItem(CatalogItemOrdered itemOrdered, decimal unitPrice, int units)
        {
            ItemOrdered = itemOrdered;
            UnitPrice = unitPrice;
            Units = units;
        }
    }

}
