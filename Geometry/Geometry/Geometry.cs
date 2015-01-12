using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Geometry
    {
        struct Point
        {
            public double x;
            public double y;
            public Point(double x1, double y1)
            {
                x = x1;sdfsdfsdfsd
                y = y1;
            }
        }
        private Point o;
        private double a;
        private double b;
        private Point t;
        public Geometry(double x1, double y1, double w, double h, double x2, double y2)
        {
            o = new Point(x1, y1);
            a = w / 2;
            b = h / 2;
            t = new Point(x2 - x1 - a, y2 - y1 - b);
        }
        public bool CheckDot()
        {
            return ((t.x * t.x) / (a * a)) + ((t.y * t.y) / (b * b)) <= 1;
        }
    }
}
