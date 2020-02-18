using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var alexa = new Alexa(); Console.WriteLine(alexa.Talk());

            alexa.Configure(x => { x.OwnerName = "Bob Marly"; x.GreetingMessage = $"Hello {x.OwnerName},I'm at your service"; return x; }); Console.WriteLine(alexa.Talk()); Console.WriteLine("press any key to exit ..."); Console.ReadLine();
        }
    }
    public class Alexa
    {
        public string GreetingMessage = "Hello, i am alexa"; public string OwnerName = "";
        internal void Configure(Func<Alexa, Alexa> p) { GreetingMessage = p(this).GreetingMessage; }
        internal string Talk() { return GreetingMessage; }
    }
}
