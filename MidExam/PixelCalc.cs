using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidExam
{
    public static class PixelCalc
    {
        private static double diagonal;
        private static double ppi;
        private static double dotPitch;

        public static double PPI(int diagonalSize)
        {
            ppi = diagonal / diagonalSize;
            return ppi;
        }

        public static double DiagonalSize(int width,int height)
        {
            diagonal =Math.Sqrt((width * width) + (height * height));

            return diagonal;
        }

        public static double DotPitch(int diagonalSize)
        {
            dotPitch = (diagonalSize / diagonal) * (25.4);
            return dotPitch;
        }
    }

}
