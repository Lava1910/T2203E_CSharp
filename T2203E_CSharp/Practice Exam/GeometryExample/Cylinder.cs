using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.Practice_Exam.GeometryExample
{
    public class Cylinder
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public double BaseArea { get; private set; }
        public double LateralArea { get; private set; }
        public double TotalArea { get; private set; }
        public double Volume { get; private set; }
        public Cylinder() { }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }


        public void Input()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Console.Write("Radius: ");
            Radius = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            Height = double.Parse(Console.ReadLine());
        }


        public void Process(double Radius, double Height)
        {
            BaseArea = Math.PI * Radius * Radius;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public string Result()
        {
            return "Base Area: " + Math.Round(BaseArea,2) + "\n" +
           "Lateral Area: " + Math.Round(LateralArea, 2)  + "\n" +
           "Total Area: " + Math.Round(TotalArea, 2)  + "\n" +
           "Volume: " + Math.Round(Volume, 2) ;
        }

        public class Program
        {
            static void Main(string[] args)
            {
                Cylinder cylinder = new Cylinder();
                cylinder.Input();
                cylinder.Process(cylinder.Radius,cylinder.Height);
                Console.WriteLine(cylinder.Result());
            }
        }
    }
}
