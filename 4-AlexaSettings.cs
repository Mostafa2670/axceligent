using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaSettings
{
    class Program
    {

        static void Main(string[] args)
        {
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa

            alexa.Configure(x =>
            {
                x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
                x.OwnerName = "Bob Marley";
                return x;
            });

            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service

            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();

        }
    }

    internal class Alexa
    {
        internal string GreetingMessage { get; set; } = "";
        internal string OwnerName { get; set; } = "";
        internal bool Config { get; set; } = false;
        public Alexa()
        {
           
        }

        
        internal string Talk()
        {

            if (Config)
            {
                return ($"Hello {OwnerName},I'm at your service");
            }
            else
            {
                return ($"Hello ,I'm Alexa");
            }
                
           
            
        }

        internal Alexa Configure(Func<Alexa, Alexa> p)
        {
            GreetingMessage = p(this).GreetingMessage;
            OwnerName = p(this).OwnerName;
            Config = true;
            return this;

        }
    }
   
}
