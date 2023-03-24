
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pudelko
{
    public sealed class Pudelko
    {

        public double A { get; set; } = 10;
        public double B { get; set; } = 10;
        public double C { get; set; } = 10;
        public UnitOfMeasure unit;
        
        public Pudelko()
        {
            if (A < 0 || B < 0 || C < 0) throw new ArgumentOutOfRangeException();
            if ((A > 10 || B > 10 || C > 10) && unit == UnitOfMeasure.meter) throw new ArgumentOutOfRangeException();
           

        }
        public override string ToString() => $"({A}m x {B}m x {C}m)";
    }
}
