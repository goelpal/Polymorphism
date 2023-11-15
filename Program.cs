// Polymorphism examples

Console.WriteLine("Polymorphism");

Car car = new Car();   
Bicycle bicycle = new Bicycle();
Boat boat = new Boat();

//Car[] vehicle = { car, bicycle, boat };// We cannot add other types of objects to car array

Vehicle[] vehicle = { car, bicycle, boat };

foreach (Vehicle v in vehicle)
{
    v.Go();
}

Console.ReadLine();

class Vehicle 
{
    public virtual void Go()
    {
        Console.WriteLine("The vehicle is moving");
    }
}

class Car : Vehicle 
{
    public override void Go()
    {
        Console.WriteLine("The car is moving");
    }
}

class Bicycle : Vehicle 
{
    public override void Go()
    {
        Console.WriteLine("The Bicycle is moving");
    }
} 

class Boat : Vehicle 
{
    public override void Go()
    {
        Console.WriteLine("The boat is moving");
    }
}    
