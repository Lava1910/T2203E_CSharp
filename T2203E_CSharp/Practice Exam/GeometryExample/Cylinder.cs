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
            Console.WriteLine();
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
            return "Radius: " + Radius + " | " + 
           "Height: " + Height + "\n" +
           "Base Area: " + Math.Round(BaseArea,2) + " | " +
           "Lateral Area: " + Math.Round(LateralArea, 2)  + " | " +
           "Total Area: " + Math.Round(TotalArea, 2)  + " | " +
           "Volume: " + Math.Round(Volume, 2) ;
        }

    }
}
