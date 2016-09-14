using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerics
{
    public class Array
    {
        public Array() { }

        public Array(string one, string two, string three, string four)
        {

            // effektivt når man vet lengden på arrayen
            var colorOptions = new string[4];
            colorOptions[0] = one;
            colorOptions[1] = two;
            colorOptions[2] = three;
            colorOptions[3] = four;

            // collection initialiser
            string[] colorOptionsTwo = { "En", "To", "Tre" };

            // skrive ut som i javascript
            // iterere foreach eller for (kan editere under loop det kan man ikke paa foreach)

            // generics - type-safe


        }
        public V metodeNavn<V>(V resultvalue)

        {

            V value = resultvalue;
            return value;

        }

    }

    // brukes når parameteren varierer, nameprefix

    // sjekke opp --- Generic Constraints ---
    // where T : struct - value type
    // where T : class - reference
    // where T : new() - type med parameterløs const
    // where T : Vendor (arv)
    // where T : IVendor (interface)


    public class Generics<T>
    {

        public Generics()
        {
        }

        public Generics(T result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }



        public T Result { get; set; }
        public string Message { get; set; }




    }

    public class GenericList<T>
    {



        public GenericList()
        {
            var liste = new List<T>();

            Object value;
            //try get value
            if (value.enMetode("verdinavn", out value)
                {
                Console.WriteLine(value);
            }


        }

        public GenericList(T message) : this()
        {

        }



        public T Result { get; set; }
        public string Message { get; set; }




    }


    /// Generic Collection interface
    /// IEnumerable, ICollection, IList
    /// Arves av array og List automatisk, IDicionary kommer med directories
    /// public staic List<string> SendEmail(IList<vendor> vendors, string message) - kan da sende inn array eller liste
    /// Generic interface når man passer collections til metoder. 
    /// 
    /// IEnumerable -> kan iterere men ikke legge til fjerne elementer - readonly
    ///
    /// yield -> husker hvor den er ved return. returnerer kun en av gangen. Lazy evaluation
    ///
    ///

    // Events delegates og event handlers

    // Events -> notifications. 
    // Delegates -> pipline mellom event og eventhandler. 
    /// 

    // Creating delegate

    public delegate void Funksjon(parametre);

    // Handler

    public void handlernavn(samme parmetre);

    // Connection

    Funksjon navn = new Funksjon(handlernavn);

    navn(parametre);

    // Kombinere flere

    navn1 += navn2;
        navn1(parametre);

    // Kan putte (Funksjon navn) inn i en funksjon for å gjøre det dynamisk
    // return value -> returnerer kun siste delegate

    // Event:

    public event DelegateNavn eventNavne;

    protected virtual void Navn(parametre som går igjen);
    {

    var del = evenvariabelnavn as delegate/eventhandlernavnet;
    if (del != null)
        {

        //handle event
}

}



    // Delegate (method, target, getInvocationsList())

    // Lambdas -> effektiv programmering
    // inline metode hvor compileren gjør magi
    // 

    public void Process(int x, int y);










}
