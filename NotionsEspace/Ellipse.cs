using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsEspace
{
    class Ellipse
    {
        public double R1 { get; private set; }
        public double R2 { get; private set; }
        public Point Centre { get; private set; }

        public Ellipse(double r1, double r2, Point centre)
        {
            this.R1 = r1;
            this.R2 = r2;
            this.Centre = centre;
        }

        public Ellipse(double r1, double r2, double x, double y, double z)
        {
            this.R1 = r1;
            this.R2 = r2;
            this.Centre.X = x;
            this.Centre.Y = y;
            this.Centre.Z = z;
        }
    }
}
