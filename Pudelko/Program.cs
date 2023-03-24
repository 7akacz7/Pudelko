using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Pudelko
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Pudelko p1 = new Pudelko();
            p1.A = 9;
            p1.unit = UnitOfMeasure.meter;
            p1.B = 13;
            Console.WriteLine(p1);
            
        }
    }
}