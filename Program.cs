using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static attribute shows all that is share by
            //its an attribute on the class itself not on the
            Songs holiday = new Songs("Holiday", "Green Day", 5);
            Songs kashmir = new Songs("Kashmir", "Led Zeppelin",10);
            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
        }
    }
}
