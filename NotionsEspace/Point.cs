using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsEspace
{
    class Point
    {
        // Attributs
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Methodes
        public Point(double x, double y, double z){
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double Distance(Point P2)
        {
            double dist = Math.Sqrt((Math.Pow(this.X - P2.X, 2) + Math.Pow(this.Y - P2.Y, 2) + Math.Pow(this.Z - P2.Z, 2)));

            return dist;
        }
        public double Distance(Circle C1)
        {
            double dist;
            if ( = )
            {

            }
            dist = this.Distance(C1.Centre) - C1.Diam;
            return dist;
        }
        public bool Egal(Point P2)
        {
            if ((this.X == P2.X) && (this.Y == P2.Y) && (this.Z == P2.Z))
            {
                return true;
            }
            else return false;
        }
        public bool appartient(Droit D1)
        {
            if (this.Egal(D1.P1) && this.Egal(D1.P2))
            {
                return true;
            }
            else return false;
        }
        public bool appartient(Circle C1)
        {
            if (this.Distance(C1.Centre) == C1.Diam)
            {
                return true;
            }
            else return false;
        }
        public bool appartient(Ellipse E1)
        {
            if (this.Distance(E1.Centre) == E1.Diam)
            {
                return true;
            }
            else return false;
        }
    }
}
