using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.Session1
{
    public class Human
    {
        public string name;
        public int age;

        public int id;

        public static int xyz;

        public Human()
        {

        }

        public Human(string s)
        {
            this.name = s;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Email { get; set; }

        public void Run()
        {
            Console.WriteLine("Running....");
            this.name = "La Viet Anh";
        }

        public static void ScreenShot()
        {

        }

        public virtual void Eat()
        {

        }
    }
}
