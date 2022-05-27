using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12_Shapes
{
    public class MyPoint
    {
        private int x = 0;
        private int y = 0;

        public MyPoint()
        {
            x = 0;
            y = 0;
        }

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string toString()
        {
            return $"({this.x},{this.y})"; // (x,y)
        }
    }
}
