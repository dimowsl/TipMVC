using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TipMVCConsole.View
{
    class Display
    {

        public double Amount { get; set; }//vhod
        public double Percent { get; set; }//vhod
        public double Total { get; set; }//izhod
        public double Tip { get;  set; }//izhod

        public void Input()
        {
            Console.Write("Amount = ");
            Amount = double.Parse(Console.ReadLine());
            Console.Write("Tip =");
            Percent = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Tip is: {Tip:C}");
            Console.WriteLine($"Total will be: {Total:C}");
        }
    }
}

