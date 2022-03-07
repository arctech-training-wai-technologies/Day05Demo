// See https://aka.ms/new-console-template for more information
class User : IUser
{
    CommuterBike commuterBike1 = new CommuterBike();
    CommuterBike commuterBike2 = new CommuterBike();

    public void GoToWork()
    {
        commuterBike1.Initialize(125, 10);
        commuterBike1.Start();
        commuterBike1.Accelerate();
        commuterBike1.Brake();
        commuterBike1.SetMaxSpeed(200);
        //commuterBike1._maxSpeed = 200;

        commuterBike2.Initialize(115, 12);
        commuterBike2.SetColor(ConsoleColor.Red);
        commuterBike2.Start();
        commuterBike2.Accelerate();
        commuterBike2.Brake();
        commuterBike1.SetMaxSpeed(20000);
        //commuterBike2._maxSpeed = 50000;
    }
}
