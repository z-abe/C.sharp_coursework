using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public abstract class Shape
    {
        public string Name { get; set; }
        private double value;

        public Shape(string name, double value)
        {
            this.Name = name;
            this.value = value;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name} has a value of {value} and an area of {GetArea()}");
        }

        public abstract double GetArea();
    }

