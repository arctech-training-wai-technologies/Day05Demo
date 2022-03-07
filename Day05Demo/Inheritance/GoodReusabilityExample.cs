// See https://aka.ms/new-console-template for more information

namespace Day05Demo.Inheritance;
class OoPlane
{
    public void Fly()
    {
        Console.WriteLine("Plane is Flying with bug fixed");
    }

    public void Refuel()
    {
        Console.WriteLine("Plane is Refueling");
    }
}

class OoAdvancedPlane : OoPlane
{
    public void FlyReverse()
    {
        Console.WriteLine("OoPlane is advanced and flying reverse!!");
    }
}