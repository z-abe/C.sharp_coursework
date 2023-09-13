using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, double value, double radius) : base(name, value)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }

