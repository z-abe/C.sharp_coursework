using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(string name, double value, double @base, double height) : base(name, value)
    {
        this.Base = @base;
        this.Height = height;
    }

    public override double GetArea()
    {
        return 0.5 * Base * Height;
    }

    public double GetHeight()
    {
        return Height;
    }
}

