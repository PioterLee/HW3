using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3
{
    class MyPoint
    {
        public double Point_X;
        public double Point_Y;

        public double DisdanceToMe(MyPoint a)
        {
            return Math.Sqrt((a.Point_X - Point_X) * (a.Point_X - Point_X) + (a.Point_Y - Point_Y) * (a.Point_Y - Point_Y));
        }
    }
}
