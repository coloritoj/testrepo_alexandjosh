using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class OtherRectangle
    {
        public int length;

        public int width;

        public int area;

        public OtherRectangle(int L, int W)
        {
            this.length = L;

            this.width = W;

            this.area = L * W;
        }
    }
}
