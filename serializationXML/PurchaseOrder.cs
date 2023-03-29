using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeXML
{
    public class PurchaseOrder
    {
        public Address ShipTo;
        public string OrderDate;
        public OrderedItem[] OrderedItems;

        public decimal SubTotal;
        public decimal ShipCost;
        public decimal TotalCost;
    }
}
