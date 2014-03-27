using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3
{
    class PinBoard
    {
        public int Rows=1;
        public int Cols=1;
        public int XIntervals = 1;
        public int YIntervals = 1;
        public MyPoint[,] PinArray = null;

        public void CreatePins()
        {
            PinArray = new MyPoint[Rows, Rows];
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    PinArray[i, j] = new MyPoint();
        }

        public void SetPinsPosition()
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    PinArray[i, j].Point_X = i * XIntervals;
                    PinArray[i, j].Point_Y = j * YIntervals;
                }
        }
    }
}
