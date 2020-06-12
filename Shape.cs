using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingDemo {
    public class Shape {
        public const float PI = 3.14f;
    }
    public class Circle : Shape {
        public double Redius { get; }
        public Circle(double redius) {
            Redius = redius;
        }
    }
    public class Rectangel : Shape {
        public double Lenght { get; }
        public double Height { get; }
        public Rectangel(double lenght, double height) {
            Lenght = lenght;
            Height = height;
        }
    }
    public class Triangle : Shape {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double @base, double height) {
            Base = @base;
            Height = height;
        }
    }
}
