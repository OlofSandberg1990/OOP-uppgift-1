namespace OOP_uppgift_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle obj1 = new Circle(5);        //creating two new objetcs from the circle-class
            Circle obj2 = new Circle(6);

            Console.WriteLine("The area for obj1 is : {0}", obj1.GetArea());        //calling the GetArea-method for obj1
            Console.WriteLine("The range for obj1 is : {0}", obj1.GetRange());      //calling the GetRange-method for obj1
            Console.WriteLine();

            Console.WriteLine("The area for obj2 is {0}", obj2.GetArea());          //calling the GetArea-method for obj2
            Console.WriteLine("The range for obj2 is : {0}", obj2.GetRange());      //calling the GetRange-method for obj2




            Triangle obj3 = new Triangle(14, 12);                                   //another object from the class Triangle.

            Console.WriteLine();
            Console.WriteLine("The area for obj3 is : {0} ", obj3.GetArea());       //calling the GetArea-method from the triangle-class.

            Console.ReadKey();

        }


    }

    public class Circle
    {
        float _pi = 3.141f;
        int _radius = 0;

        public Circle(int radius)           //creating two variables and a constructor
        {

            this._radius = radius;              


        }


        public double GetArea()
        {

            double answer = _radius * _radius * _pi;
            return Math.Round(answer, 2);           //rounding the answer to two decimals.

        }
        public double GetRange()
        {

            double answer = _radius + _radius * _pi;
            return Math.Round(answer, 2);



        }


    }

    public class Triangle
    {

        public int _baseTriangle;
        public int _heightTriangle;

        public Triangle(int baseTriangle, int heightTriangle)
        {
            _baseTriangle = baseTriangle;
            _heightTriangle = heightTriangle;
        }

        public double GetArea()
        {

            double answer = (_baseTriangle + _heightTriangle) / 2;
            return Math.Round(answer, 2);


        }

    }
}