using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HorizontalLine line = new HorizontalLine(1, 12, 6, '+');
            line.Draw();

            VerticalLine lineV = new VerticalLine(3,1,8,'-');
            lineV.Draw();


            Console.ReadKey();
        }

       
    }
}
