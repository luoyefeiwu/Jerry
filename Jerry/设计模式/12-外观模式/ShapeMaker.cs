using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_外观模式
{
    /// <summary>
    /// 外观类
    /// </summary>
    public class ShapeMaker
    {
        private Shape circle;
        private Shape rectangle;
        private Shape square;

        public ShapeMaker()
        {
            circle=new Circle();
            rectangle=new Rectangle();
            square=new Square();
        }

        public void drawCircle()
        {
            circle.draw();
        }

        public void drawRectangle()
        {
            rectangle.draw();
        }

        public void drawSquare()
        {
            square.draw();
        }
    }
}
