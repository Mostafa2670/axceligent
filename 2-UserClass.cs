using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQuestion2
{
    class User
    {
        class Globals
        {
            public static List<string> result_List = new List<string>();
        }

        public void Add(string userName)
        {
            Globals.result_List.Add(userName);
        }

        public string GetUsersCount()
        {
            return Globals.result_List.Count.ToString();
        }
    }
}
