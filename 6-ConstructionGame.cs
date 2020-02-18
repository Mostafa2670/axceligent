using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptitude
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHouse = new Building()
                .AddKitchen()
                .AddBedroom("master")
                .AddBedroom("guest")
                .AddBalcony();

            var normalHouse = myHouse.Build();

            //kitchen, master room, guest room, balcony
            Console.WriteLine(normalHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");

            var luxuryHouse = myHouse.Build();

            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(luxuryHouse.Describe());

        }
    }

    internal class Building
    {
        List<String> msg;



        public Building()
        {
            msg = new List<string>();
        }
        bool build = false;

        internal Building AddBalcony()
        {
            msg.Add("Balcony");
            return this;
        }

        internal Building AddBedroom(string v)
        {
            msg.Add(v + " room");
            return this;
        }

        internal Building AddKitchen()
        {
            msg.Add("Kitchen");
            return this;
        }

        internal Building Build()
        {
            build = true;
            return this;
        }

        internal string Describe()
        {
            if (build)
            {
                try
                {
                    for (int i = 0; i < msg.Count - 1; i++)
                    {
                        Console.Write(msg[i]+",");
                    }
                    for (int i = msg.Count - 1; i < msg.Count; i++)
                    {
                        Console.Write(msg[i]);
                    }
                }
                catch{}
               
                Console.WriteLine("perss any key to close this window");
                Console.ReadKey();
            }
            return "";
        }
    }
}

