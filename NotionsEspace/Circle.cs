using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionsEspace
{
    class Circle : Ellipse
    {
        public double Diam { get; private set; }
        public Circle(double diam, Point centre) : base(diam, diam, centre)
        {
            Diam = diam;
        }

    }
}
