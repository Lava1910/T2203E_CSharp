using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.Session4
{
    public delegate void StringToVoid (string s);
    public class DemoDelegate
    {
        public DemoDelegate() { }

        public void ShowInfo(string s) 
        {
            Console.WriteLine("Hello " + s);
        }

        public static void SayHello(string str)
        {
            Console.WriteLine(str);
        }
    }
}
