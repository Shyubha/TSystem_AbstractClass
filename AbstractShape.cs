using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_AbstractClass
{
    abstract public class AbstractShape
    {
        abstract public void CalculateArea();
    }
    public class Reactangle : AbstractShape
    {
        private int w;
        private int l;
        private int result;

        public Reactangle(int width, int lengthg)
        {
            w = width;
            l = lengthg;

        }
        public override void CalculateArea()
        {
            result = w * l;
        }
        public override string ToString()
        {
            return "Result is" + result;
        }

    }
}
