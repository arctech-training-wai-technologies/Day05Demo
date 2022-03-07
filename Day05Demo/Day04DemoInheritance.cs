// See https://aka.ms/new-console-template for more information

using Day05Demo.Inheritance;
using Day05Demo.InheritanceExample2;

public class Day04DemoInheritance
{
    public static void TestWrongResuabilityExample()
    {
        Console.WriteLine("Hello, World!");
        Plane p = new Plane();
        p.Fly();
        p.Refuel();

        AdvancedPlane ap = new AdvancedPlane();
        ap.Refuel();
        ap.Fly();
        ap.FlyReverse();
    }   
    
    public static void TestOoResuabilityExample()
    {
        OoPlane p = new OoPlane();
        p.Fly();
        p.Refuel();

        OoAdvancedPlane ap = new OoAdvancedPlane();
        ap.Refuel();
        ap.Fly();
        ap.FlyReverse();
    }

    internal static void TestOoExample2()
    {
        CommuterCar commuterCar = new CommuterCar();
        commuterCar.Initialize(120, 25);
        commuterCar.Accelerate(5000);
        commuterCar.ShowCurrentSpeed();

        RacingCar racingCar = new RacingCar();
        racingCar.Initialize(550, 15);
        racingCar.SetColor(ConsoleColor.Red);
        racingCar.Accelerate(5000);
        racingCar.ShowCurrentSpeed();
    }
}