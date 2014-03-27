using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3
{
    class Triangle
    {
        /*
        public MyPoint PointIn1 = new MyPoint();
        public MyPoint PointIn2 = new MyPoint();
        public MyPoint PointIn3 = new MyPoint();
        */
        public MyPoint[] PointIn = new MyPoint[3];

        public void CreatePins()
        {
            for (int i = 0; i < 3; i++)
                    PointIn[i] = new MyPoint();
        }

        static public double disdance(MyPoint a, MyPoint b)
        {
            return Math.Sqrt((a.Point_X - b.Point_X) * (a.Point_X - b.Point_X) + (a.Point_Y - b.Point_Y) * (a.Point_Y - b.Point_Y));
        }

        public bool isValid() //檢查三角形是否合法
        {
            double D1 = PointIn[0].DisdanceToMe(PointIn[1]);
            double D2 = PointIn[1].DisdanceToMe(PointIn[2]);
            double D3 = PointIn[2].DisdanceToMe(PointIn[0]);
            if ((D1 + D2) <= D3 || (D1+D3)<=D2 ||(D2+D3)<=D1)
                return false;
            else
                return true;
        }
        public double Perimeter() //計算周長
        {
            double D1 = PointIn[0].DisdanceToMe(PointIn[1]);
            double D2 = PointIn[1].DisdanceToMe(PointIn[2]);
            double D3 = PointIn[2].DisdanceToMe(PointIn[0]);
            return D1 + D2 + D3;
        }
        public double Area() //計算面積
        {
            double D1 = PointIn[0].DisdanceToMe(PointIn[1]);
            double D2 = PointIn[1].DisdanceToMe(PointIn[2]);
            double D3 = PointIn[2].DisdanceToMe(PointIn[0]);
            double p = (D1 + D2 + D3) / 2;
            return Math.Sqrt(p * (p - D1) * (p - D2) * (p - D3));
        }
        public double RadiusOfCircumcircle() //計算外接圓半徑
        {
            double D1 = PointIn[0].DisdanceToMe(PointIn[1]);
            double D2 = PointIn[1].DisdanceToMe(PointIn[2]);
            double D3 = PointIn[2].DisdanceToMe(PointIn[0]);
            return D1*D2*D3 / (4 * Area());
        }
        public bool isRight() //檢查三角形是否為直角
        {
            double D1 = PointIn[0].DisdanceToMe(PointIn[1]);
            double D2 = PointIn[1].DisdanceToMe(PointIn[2]);
            double D3 = PointIn[2].DisdanceToMe(PointIn[0]);
            if ((D1 * D1 + D2 * D2 == D3 * D3) || (D1 * D1 + D3 * D3 == D2 * D2) || (D3 * D3 + D2 * D2 == D1 * D1))
                return true;
            else
                return false;
        }
    }
}
