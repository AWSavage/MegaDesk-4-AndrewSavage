using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace MegaDesk_3_AndrewSavage
{
    class DeskQuote
    {

        public enum ShippingSpeed
        {
            Days3,
            Days5,
            Days7,
            Days14,
        }

        Desk desk = new Desk();
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public ShippingSpeed Shipping { get; set; }


        public double getSurArea()
        {
            int surfaceArea = desk.Width * desk.Depth;
            double addSurCost = 0.00;
            if(surfaceArea > 1000)
            {
                double size = surfaceArea - 1000;
                addSurCost = size * 1.00;
            }
            return addSurCost;
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
            switch (desk.SurfaceMaterial)
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
            double cost = desk.Drawers * 50.00;
            return cost;
        }

        public double getTotal()
        {
            double baseAmount = 200.00;
            double price = 0.00;
            price = baseAmount + getSurArea() + getDraCost() + getMaterialCost() + getDelCost();
            return price;
        }
    }
}
