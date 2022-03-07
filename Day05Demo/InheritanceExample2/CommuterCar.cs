// See https://aka.ms/new-console-template for more information

namespace Day05Demo.InheritanceExample2;
class CommuterCar : Car
{
    public void Accelerate(int speed)
    {
        if (speed < 120)
            _currentSpeed = speed;
        else
            _currentSpeed = 120;
    }
}
