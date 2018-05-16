using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace MegaDesk_3_AndrewSavage
{
    class DeskQuote : Desk
    {

        public enum ShippingSpeed
        {
            [Description("3")]
            Days3 = 3,
            [Description("5")]
            Days5 = 5,
            [Description("7")]
            Days7 = 7,
            [Description("14")]
            Days14 = 14,
        }

        public Desk Desk { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public ShippingSpeed Shipping { get; set; }

        public DeskQuote()
        {
            Desk = new Desk();
            Name = " ";
            Date = DateTime.Now;
            Total = 0;
            Shipping = DeskQuote.ShippingSpeed.Days14;
        }
    }
}
