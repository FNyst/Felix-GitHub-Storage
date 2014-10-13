using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.color = "Blue";
            myCar.brand = "Volvo";
            myCar.length = 2.5f;
            myCar.weight = 2.15F;
            

            Console.WriteLine("My Car is a {0} {1} and it is {2} meter long and weigh {3} ton", myCar.color,myCar.brand,myCar.length,myCar.weight);
            Console.WriteLine("My Car is made in {0} ", );
            Console.ReadKey();

        }
    }
}
