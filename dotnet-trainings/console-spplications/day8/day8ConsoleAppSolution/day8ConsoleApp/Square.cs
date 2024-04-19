using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8ConsoleApp
{
    public class Square: Shape
    {
        public new void Draw()
        {
            Console.WriteLine("This is square!");
        }
    }
}
