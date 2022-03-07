// See https://aka.ms/new-console-template for more information


namespace Day05Demo.InheritanceExample2;
class RacingCar : Car
{
    public void Accelerate(int speed)
    {
        _currentSpeed = speed;
    }
}