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
    }
}
