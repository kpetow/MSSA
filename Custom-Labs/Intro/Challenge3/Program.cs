using System;
using System.IO; 
using System.Text.RegularExpressions;
using System.Globalization;

abstract class Shape
    {               
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public abstract double GetSides();
       
    }

    class Square : Shape
    {
        private double side1;
        private double side2;
        public Square() { }
        public Square(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double CalculateArea()
        {
            double area = this.side1 * this.side2;
            return area;                      
        }
        public override double GetSides()
        {
            double readoutput=0;
            string pattern = @"^[Rr]ectangle,",
            Regex rg = new Regex(pattern);
            //creating an object of NumberFormatInfo
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            try {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("input.txt")) {
                    string line;
                // Read and display lines from the file until 
                // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != empty) {
                        if(Regex.Match(line , pattern).Success){
                            Console.WriteLine(line);
                            try
                            {
                                //try for variables with floating points
                                string [] sides = Regex.Split(line, @"(^[rR]ectangle),([\d]+\.[\d]+),([\d]+\.[\d]+)");
                                this.side1 = Double.Parse(sides[2], System.Globalization.CultureInfo.InvariantCulture);   
                                this.side2 = Double.Parse(sides[3], System.Globalization.CultureInfo.InvariantCulture);
                            }
                            catch
                            {
                                string [] sides = Regex.Split(line, @"(^[rR]ectangle),([\d]+),([\d]+)");
                                this.side1 = Double.Parse(sides[2], System.Globalization.CultureInfo.InvariantCulture);   
                                this.side2 = Double.Parse(sides[3], System.Globalization.CultureInfo.InvariantCulture);
                            }
                        }                    
                    }
                }
            } 
            catch (Exception e) 
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return readoutput;  
        }
    }

//circle triangle
    class Triangle : Shape
    {
        private double tside1;
        private double tside2;
        private double tside3;
        public Triangle() { }
        public Triangle(double tside1, double tside2, double tside3)
        {
        this.tside1 = tside1;
        this.tside2 = tside2;
        this.tside3 = tside3;
        }
        public override double CalculateArea()
        {
            double s = Convert.ToDouble((this.tside1+this.tside2+this.tside3)/2);
            double area = Convert.ToDouble(Math.Sqrt(s*(s-this.tside1)*(s-this.tside2)*(s-this.tside3)));
            return area;
        }
        public override double CalculatePerimeter()
        {
            double perimeter = this.tside1+this.tside2+this.tside3;
            return perimeter;
        }
        public override void GetSides()
        {
            string pattern = @"^[Tt]riangle,";
            Regex rg = new Regex(pattern);
            //creating an object of NumberFormatInfo
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
        
        try 
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("input.txt")) 
            {
            string line;
            // Read and display lines from the file until
            // the end of the file is reached.
            while ((line = sr.ReadLine()) != null) {
                if(Regex.Match(line , pattern).Success)
                {
                    Console.WriteLine(line);
                    try
                    {
                        //try for variables with floating points
                        string [] sides = Regex.Split(line, @"(^[Tt]riangle),([\d]+\.[\d]+),([\d]+\.[\d]+),([\d]+\.[\d]+)");
                        this.tside1 = Double.Parse(sides[2], System.Globalization.CultureInfo.InvariantCulture);
                        this.tside2 = Double.Parse(sides[3], System.Globalization.CultureInfo.InvariantCulture);
                        this.tside3 = Double.Parse(sides[4], System.Globalization.CultureInfo.InvariantCulture);
                    }
                    catch
                    {
                        string [] sides = Regex.Split(line, @"(^[Tt]riangle),([\d]+),([\d]+),([\d]+)");
                        this.tside1 = Double.Parse(sides[2], System.Globalization.CultureInfo.InvariantCulture);
                        this.tside2 = Double.Parse(sides[3], System.Globalization.CultureInfo.InvariantCulture);
                        this.tside3 = Double.Parse(sides[4], System.Globalization.CultureInfo.InvariantCulture);
                    }
                }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read");
        }
        }
    }
    class Circle : Shape
    {
        private double radius;
        public Circle() { }
        public Circle(double r)
        {
        this.radius = r;
        }

        public override double CalculateArea()
        {
            double area = (double)(Math.Pow(this.radius, 2) * Math.PI);
            return area;
        }
        public override double CalculatePerimeter()
        {
            double perimeter = Math.PI*2*this.radius;
            return perimeter;
        }
        public override void GetSides()
        {
            
        }
    }

class App
{
     static void Main(string[] args)
    {
        Console.WriteLine("Hello, I will calculate Perimeter and Area of several geometric figures");

        //square calculation
        Shape square = new Square();
        square.GetSides();
        Console.WriteLine("The area of the square/rectangle is equal to {0}", Square.CalculateArea());

        //triangle calculation
        
        //circle calculation
        
        //wait for user keyboard input before closing 
        Console.ReadKey();
    }
}