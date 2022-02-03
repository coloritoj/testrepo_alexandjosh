using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Rectangle
    {
        private int length;

        private int width;

        private int area;

        public Rectangle(int L, int W)
        {
            this.length = L;

            this.width = W;

            this.area = length * width;
        }

        public int GetLength()
        {
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetArea()
        {
            return area;
        }

        public void SetLength(int newLength)
        {
            length = newLength;
            area = length * width;
        }

    }
}
