using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.Practice_Exam.IandP;

public class Animal
{
    public double Weight { get; set; }
    public string Name { get; set; }
    public Animal(double weight, string name)
    {
        Weight = weight;
        Name = name;
    }

    public void Show()
    {
        Console.WriteLine("Name: " + Name + " " + "Weight: " + Weight + "\n");
    }

    public void SetMe (double weight, string name)
    {
        Weight = weight; 
        Name = name;
    }


}
