using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Reactangle shape = new Reactangle(54, 89);
            shape.CalculateArea();
            Console.WriteLine(shape);
            Console.ReadLine();


        }
    }
}
