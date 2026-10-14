using System;
using System.Collections.Generic;
using System.Text;

namespace Sesi1
{
    public class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Sound()
        {
            Console.WriteLine("Car make sound Brummmm");
        }
    }
}
