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
            this.x = 0;
            this.y = 0;
        }

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X 
        {
            get {
                return this.x;
            }
            set
            {
                if (x >= 0)
                {
                    this.x = value;
                }                
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int[] getXY()
        {
            return new int[2] { this.x, this.y };
        }

        public void setXY(int[] xy)
        {
            this.x = xy[0];
            this.y = xy[1];
        }
        
        public override string ToString()
        {
            return $"({this.x},{this.y})"; // (x,y)
        }

        /*
        public double distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        }*/
        public double distance(int x, int y) => Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));

        public double distance(MyPoint otherPoint) => distance(otherPoint.x, otherPoint.y);

        public double distance() => distance(0, 0);

    }
}
