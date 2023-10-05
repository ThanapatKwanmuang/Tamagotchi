using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            string you = "";
            string name = "";

            while(name == "")
            {
                Write("Name your Tamagotchi!");
                YouTalk(you);
                name = Console.ReadLine();
            }
        }
    }
}
