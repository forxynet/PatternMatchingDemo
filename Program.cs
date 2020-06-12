using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingDemo {
    class Program {
        static void Main(string[] args) {


            decimal mynumber = 1_9_9_1_2_3_4_5_6_7_8_9_1_0;
            Console.WriteLine($"mynumber is:{mynumber} ");

            Rectangel sequare = new Rectangel(30, 60);
            DisplayArea(sequare);
            Rectangel rectangel = new Rectangel(10, 5);
            DisplayArea(rectangel);
            Circle circle = new Circle(10);
            DisplayArea(circle);
            Triangle triangle = new Triangle(10, 5);
            DisplayArea(triangle);

            Console.ReadKey();
        }

        private static void DisplayArea(Shape shape) {
            switch (shape) {
                case Rectangel r when r.Height == r.Lenght:
                    Console.WriteLine($"{r.Height} * {r.Lenght} Area of Seqaure is: " + r.Height*r.Lenght);
                    break;   
                case Rectangel r:
                    Console.WriteLine($"{r.Lenght} * {r.Height} Area of Rectangel is: " + r.Lenght * r.Height);
                    break;
                case Circle c:
                    Console.WriteLine($"{c.Redius} * {c.Redius} Area of circle is: " + c.Redius * c.Redius * Shape.PI);
                    break;
                case Triangle t:
                    Console.WriteLine($"0.5 * {t.Base} * {t.Height} Area of Triangle is:" + 0.5 * t.Base * t.Height);
                    break;
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
                case null:
                    throw new ArgumentNullException(nameof(shape));

            }
            //if (shape is Circle) {
            //    Circle c = (Circle)shape;
            //    Console.WriteLine($"{c.Redius} * {c.Redius} Area of circle is: " + c.Redius * c.Redius * Shape.PI);
            //}
            //else if (shape is Rectangel) {
            //    Rectangel r = (Rectangel)shape;
            //    Console.WriteLine($"{r.Lenght} * {r.Height} Area of Rectangel is: " + r.Lenght * r.Height);
            //}
            //else if(shape is Triangle) {
            //    Triangle t = (Triangle)shape;
            //    Console.WriteLine($"0.5 * {t.Base} * {t.Height} Area of Triangle is:" + 0.5 * t.Base * t.Height);
            //}
            //else {
            //    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            //}
        }
    }
}
