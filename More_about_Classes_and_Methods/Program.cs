using System;

namespace More_about_Classes_and_Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // myCars holds a reference to the instance of the Car class 
            // a "handle" to the bucket 
            Car myCar = new Car();

            // () --- method invocation operator

            // set properties 

            // two references to the same object in memory (a second handle) 
            Car myOtherCar = myCar;

            Car myThirdCar = new Car("Ford", "Escape", 2005, "white");

            myOtherCar = null;
            myCar = null;

            // if there are no references, the object will be removed from memory 

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            // you could get this from a configuration file, a database, etc.

            this.Make = "Nissan";
        }

        public Car(string someOtherInputParameter, string model, int year, string color)
        {
            Make = someOtherInputParameter;
            Model = model;
            Year = year;
            Color = color;
        }
    }

}
