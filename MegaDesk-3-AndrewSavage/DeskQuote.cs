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

        public double getSurArea()
        {
            int surfaceArea = Desk.Width * Desk.Depth;
            double addSurCost = 0.00;
            if(surfaceArea > 1000)
            {
                double size = surfaceArea - 1000;
                addSurCost = size * 1.00;
            }
            return surfaceArea;
        }

        public double getDelCost()
        {
            double delCost = 0.00;
            switch(Shipping)
            {
                case DeskQuote.ShippingSpeed.Days3:
                    if (getSurArea() >= 1000 & getSurArea() <= 2000)
                        delCost = 70.00;
                    else if (getSurArea() > 2000)
                        delCost = 80.00;
                    else
                        delCost = 60.00;
                    break;
                case DeskQuote.ShippingSpeed.Days5:
                    if (getSurArea() >= 1000 & getSurArea() <= 2000)
                        delCost = 50.00;
                    else if (getSurArea() > 2000)
                        delCost = 60.00;
                    else
                        delCost = 40.00;
                    break;
                case DeskQuote.ShippingSpeed.Days7:
                    if (getSurArea() >= 1000 & getSurArea() <= 2000)
                        delCost = 35.00;
                    else if (getSurArea() > 2000)
                        delCost = 40.00;
                    else
                        delCost = 30.00;
                    break;
                case DeskQuote.ShippingSpeed.Days14:
                    delCost = 0.00;
                    break;
            }
            return delCost;
        }

        public double getMaterialCost()
        {
            double matCost;
            switch (Desk.SurfaceMaterial)
            {
                case Desk.Surface.Oak:
                    matCost = 200.00;
                    break;
                case Desk.Surface.Laminate:
                    matCost = 100.00;
                    break;
                case Desk.Surface.Pine:
                    matCost = 50.00;
                    break;
                case Desk.Surface.Rosewood:
                    matCost = 300.00;
                    break;
                case Desk.Surface.Veneer:
                    matCost = 125.00;
                    break;
                default:
                    matCost = 0.00;
                    break;
            }
            return matCost;
        }

        public double getDraCost()
        {
            double cost = Desk.Drawers * 50.00;
            return cost;
        }

        public double getTotal()
        {
            double baseAmount = 200.00;
            Total = baseAmount + getSurArea() + getDraCost() + getMaterialCost() + getDelCost();
            this.Total = Total;
            return Total;
        }

        public DeskQuote(Desk desk, string Name, DateTime date, int Total, ShippingSpeed shipping)
        {
            this.Desk = desk;
            this.Name = Name;
            this.Date = Date;
            this.Total = Total;
            this.Shipping = ShippingSpeed.Days14;
        }

    }
}
