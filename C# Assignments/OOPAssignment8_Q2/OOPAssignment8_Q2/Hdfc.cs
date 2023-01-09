using System;
using System.Collections.Generic;

namespace OOPAssignment8_Q2
{
    [Software]
    class Hdfc
    {
        public int account { get; set; }
        public string name { get; set; }
        public double balance { get; set; }
        public Hdfc()
        {
            Console.WriteLine("Hdfc constructor");
        }
    }
}
