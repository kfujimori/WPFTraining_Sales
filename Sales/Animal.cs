using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class Animal
    {
        public DateTime birth { get; set; }
        public byte sexType { get; set; }
        public string name { get; set; }
    }
    class Human : Animal
    {
        public string hobby { get; set; }
    }
    class Dog : Animal
    {
        public string owner { get; set; }
    }

}
