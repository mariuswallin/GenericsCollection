using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

            // test generics construct og metode
            Method test = new Method();
            var x = test.testGenerics();
            Console.WriteLine(x.Result);

            var testGeneriskMetode = new Array();

            var k = testGeneriskMetode.metodeNavn<int>(2221341);
            Console.WriteLine(k);


        }
    }
}
