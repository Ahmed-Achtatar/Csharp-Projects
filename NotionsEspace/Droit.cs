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
        public double Coef { get; set; }
        public double Ord { get; set; }

        public Droit(Point p1, Point p2)
        {
            this.P1.X = p1.X;
            this.P1.Y = p1.Y;
            this.P1.Z = p1.Z;
            this.P2.X = p2.X;
            this.P2.Y = p2.Y;
            this.P2.Z = p2.Z;

            this.Coef = (p2.Y - p1.Y) / (p2.X - p1.X);
            this.Ord = p2.Y - (this.Coef * P2.X);
        }
        public Droit(double x1, double y1 , double z1, double x2, double y2, double z2)
        {
            this.P1.X = x1;
            this.P1.Y = y1;
            this.P1.Z = z1;
            this.P2.X = x2;
            this.P2.Y = y2;
            this.P2.Z = z2;
        }
        public Droit(Point p1, double x2, double y2, double z2)
        {
            this.P1.X = p1.X;
            this.P1.Y = p1.Y;
            this.P1.Z = p1.Z;
            this.P2.X = x2;
            this.P2.Y = y2;
            this.P2.Z = z2;
        }
        public Droit(double x1, double y1, double z1, Point p2)
        {
            this.P1.X = x1;
            this.P1.Y = y1;
            this.P1.Z = z1;
            this.P2.X = p2.X;
            this.P2.Y = p2.Y;
            this.P2.Z = p2.Z;
        }

        public bool Egal(Droit D)
        {
            bool istrue = false;
            if ((this.Coef == D.Coef) && (this.Ord == D.Ord))
            {
                istrue = true;
            }
            else istrue = false;
            return istrue;
        }
        public Point Intersection(Droit D)
        {   
            double a =  (D.Ord - this.Ord)/ (this.Coef - D.Coef);
            double b = (this.Coef * a) + this.Ord;
            Point P = new(a,b);
            return P;
        }

        public bool Appartenance(Point P)
        {
            bool isappartient;
            if (((this.Coef * P.X) + this.Ord) == P.Y)
            {
                isappartient = true;
            }
            else isappartient = false;
            return isappartient;
        }

    }
}
