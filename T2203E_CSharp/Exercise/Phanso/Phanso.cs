using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.Exercise.Phanso
{
    public class Phanso
    {
        public int Tuso { get; set; }
        public int Mauso { get; set; }

        public void Input(int Tuso, int Mauso)
        {
            Console.WriteLine("Nhập tử số: ");
            Tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mẫu số: ");
            Mauso = int.Parse(Console.ReadLine());
            if (Mauso == 0)
            {
                Console.WriteLine("Nhập lại mẫu số: ");
            }
        }

        public void Print()
        {
            Console.WriteLine("(0)/(1)", Tuso, Mauso);
        }

        public void Rutgon(int Tuso, int Mauso)
        {

        }


    }
}
