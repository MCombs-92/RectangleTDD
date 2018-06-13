using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleTest {
    public class Rectangle {

        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle() {

        }

        public Rectangle(int length, int width) {
            Length = length;
            Width = width;
        }

        static public int GetArea(int length, int width) {
            var area = length * width;
            return area;
        }

        static public int GetPerim(int length, int width) {
            var perim = (length * 2) + (width * 2);
            return perim;
        }


    }
}
