// See https://aka.ms/new-console-template for more information

namespace Day05Demo.InheritanceExample2;
class Car
{
    protected int _currentSpeed;
    private int _maxSpeed;
    private int _fuelTankCapacity;
    private ConsoleColor _color;

    public void Initialize(int maxSpeed, int fuelTankCapacity)
    {
        _maxSpeed = maxSpeed;
        _fuelTankCapacity = fuelTankCapacity;
        _color = ConsoleColor.Gray;
    }

    public void SetColor(ConsoleColor color)
    {
        _color = color;
    }

    public void ShowCurrentSpeed()
    {
        Console.WriteLine($"Current Speed= {_currentSpeed}");
    }
}
