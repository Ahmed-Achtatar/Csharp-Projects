using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsEspace
{
    class Ellipse
    {
        public Point P1 { get; private set; }
        public Point P2 { get; private set; }
        public double Height { get; private set; }
        public double Width { get; private set; }
        public Point Centre { get; private set; }

        public Ellipse(Point p1, Point p2, Point centre)
        {
            this.P1.X = p1.X;
            this.P1.Y = p1.Y;
            this.P2.X = p2.X;
            this.P2.Y = p2.Y;
            this.Centre = centre;
            this.Height = P1.Distance(this.Centre);
            this.Width = P2.Distance(this.Centre);
        }

        public Ellipse(double height, double width, Point centre)
        {
            this.P1.X = centre.X;
            this.P1.Y = centre.Y + (height/2);
            this.P1.X = centre.X + (width / 2) ;
            this.P1.Y = centre.Y ;
            this.Centre = centre;
            this.Height = height;
            this.Width = width;
        }
        public bool EgalSurface(Ellipse E)
        {
            bool isegal;
            if ((this.Width == E.Width) && (this.Height == E.Height)) isegal = true;
            else isegal = false;
            return isegal;
        }

        public double Surface()
        {
            double surface = (this.Width / 2) * (this.Height / 2) * Math.PI;
            return surface;
        }
        public double Circonference()
        {
            double circonference = 2 * Math.PI * Math.Sqrt((Math.Pow(this.Height,2) + Math.Pow(this.Width, 2)) / 2);
            return circonference;
        }
        public bool Appartenance(Point P)
        {
            double a = P.X / this.Height;
            double b = P.Y / this.Width;
            if ((a * a) + (b * b) == 1)
                return true;
            else
                return false;
        }
    }
}
