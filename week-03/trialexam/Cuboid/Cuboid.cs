using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cuboid
    {
        private int height;
        private int width;
        private int depth;

        public Cuboid(int height, int width, int depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
        }

        public int GetVolume()
        {
            return height * width * depth;
        }

        public int GetSurface()
        {
            return 2 * (height * width + height * depth + width * depth);
        }
    }
}
