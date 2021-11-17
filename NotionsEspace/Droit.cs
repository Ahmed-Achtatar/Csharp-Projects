using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsEspace
{
    class Droit
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Droit(Point p1, Point p2)
        {
            this.P1.X = p1.X;
            this.P1.Y = p1.Y;
            this.P1.Z = p1.Z;
            this.P2.X = p2.X;
            this.P2.Y = p2.Y;
            this.P2.Z = p2.Z;
        }
    }
}
