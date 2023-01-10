using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2203E_CSharp.Practice_Exam.GeometryExample;
using T2203E_CSharp.Practice_Exam.IandP;

namespace T2203E_CSharp.Practice_Exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(200, "Lion");
            Tiger tiger = new Tiger(100, "Tiger");
            lion.Show();
            tiger.Show();

            lion.SetMe(150, "Lion1");
            lion.Show();
        }
        static void Main1(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            cylinder.Input();
            cylinder.Process(cylinder.Radius, cylinder.Height);
            Console.WriteLine("Cylinder Characteristics: ");
            Console.WriteLine(cylinder.Result());
        }
    }
}
