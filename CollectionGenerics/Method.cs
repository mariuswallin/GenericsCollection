using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerics
{
    class Method
    {

        public Generics<bool> testGenerics()
        { 

        var success = false;
        var orderText = "Test";
        var result = new Generics<bool>(success, orderText);
        return result;

        }

    }
}
