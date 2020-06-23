using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1
{
    public class Human
    {
        public string FirstName { get; set; }
        public bool HasDrivingLicense { get; set; }
    }
    public class Car
    {
       public double Speed { get; set; }  
        public Color Color { get; set; }
        public Human Driver { get; set; }
    }
}
