using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_AndrewSavage
{
    class Desk
    {
        public enum Surface
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }

        public Surface SurfaceMaterial { get; set; }
        public int Drawers { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        public Desk()
        {
            Drawers = 0;
            Width = 0;
            Depth = 0;
            SurfaceMaterial = Desk.Surface.Oak;
        }

        public Desk(int width, int depth, int drawers, Surface SurfaceMaterial)
        {
            this.Width = Width;
            this.Depth = Depth;
            this.Drawers = Drawers;
            this.SurfaceMaterial = SurfaceMaterial;
        }
    }
}
