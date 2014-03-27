using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            PinBoard Board = new PinBoard();
            Triangle input = new Triangle();
            Triangle RandomTri = new Triangle();
            Random Rand = new Random();
            char chooese;
            input.CreatePins();
            RandomTri.CreatePins();
            while (true)
            {
                Console.WriteLine("請決定陣列的大小");
            RepeatRows:
                Console.Write("有多少列數: ");
                Board.Rows = int.Parse(Console.ReadLine());
                if (Board.Rows <= 0)
                {
                    Console.WriteLine("請輸入大於0整數");
                    goto RepeatRows;
                }
            RepeatCols:
                Console.Write("有多少行數: ");
                Board.Cols = int.Parse(Console.ReadLine());
                if (Board.Cols <= 0)
                {
                    Console.WriteLine("請輸入大於0整數");
                    goto RepeatCols;
                }
            RepeatXIntervals:
                Console.WriteLine("陣與陣的間隔為?");
                Board.XIntervals = int.Parse(Console.ReadLine());
                if (Board.XIntervals <= 0)
                {
                    Console.WriteLine("請輸入大於0整數");
                    goto RepeatXIntervals;
                }
            RepeatYIntervals:
                Console.WriteLine("行與行的間隔為?");
                Board.YIntervals = int.Parse(Console.ReadLine());
                if (Board.YIntervals <= 0)
                {
                    Console.WriteLine("請輸入大於0整數");
                    goto RepeatYIntervals;
                }

                Board.CreatePins();
                Board.SetPinsPosition();

                for (int i = 0; i < 2; i++) 
                {
                    RandomTri.PointIn[i] = Board.PinArray[Rand.Next(Board.Rows), Rand.Next(Board.Cols)];
                }
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("第{0}點為:({1},{2})", i + 1, RandomTri.PointIn[i].Point_X, RandomTri.PointIn[i].Point_Y);
                }
                Console.WriteLine("1.周長:{0}", RandomTri.Perimeter());
                Console.WriteLine("2.面積:{0}", RandomTri.Area());
                Console.WriteLine("3.外接圓半徑:{0}", RandomTri.RadiusOfCircumcircle());
                Console.WriteLine("4.是否為直角三角形:{0}", RandomTri.isRight());
                /*
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("請輸入第{0}點X座標:", i + 1);
                    input.PointIn[i].Point_X = double.Parse(Console.ReadLine());
                    Console.WriteLine("請輸入第{0}點Y座標:", i + 1);
                    input.PointIn[i].Point_Y = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("1.周長:{0}", input.Perimeter());
                Console.WriteLine("2.面積:{0}", input.Area());
                Console.WriteLine("3.外接圓半徑:{0}", input.RadiusOfCircumcircle());
                Console.WriteLine("4.是否為直角三角形:{0}", input.isRight());
                */

                Console.WriteLine("繼續的畫按任Y鍵");
                chooese = Convert.ToChar(Console.ReadLine());
                if (chooese == 'Y' || chooese == 'y')
                    continue;
                else
                    break;
            }
            Console.WriteLine("結束程式");
            Console.ReadLine();
        }
    }
}
