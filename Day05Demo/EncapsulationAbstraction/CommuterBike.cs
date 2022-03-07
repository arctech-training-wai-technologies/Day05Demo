
// See https://aka.ms/new-console-template for more information
// Encapsulation

// Programmer Shambu
class CommuterBike : IBike
{
    //private int _maxSpeed;
    private int _maxSpeed;
    private ConsoleColor _color;
    private int _fuelTankCapacity;

    public void Initialize(int maxSpeed, int fuelTankCapacity)
    {
        _maxSpeed = maxSpeed;
        _fuelTankCapacity = fuelTankCapacity;
        _color = ConsoleColor.Black;
    }

    public void SetColor(ConsoleColor color)
    {
        _color = color;
    }

    public void SetMaxSpeed(int maxSpeed)
    {
        if (maxSpeed > 0 && maxSpeed < 250)
            _maxSpeed = maxSpeed;
        else
            _maxSpeed = 250;
    }

    public void Start()
    {

    }

    public void Accelerate()
    {

    }

    public void Brake()
    {

    }
}
