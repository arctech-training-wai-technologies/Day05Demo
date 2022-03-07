using Day05Demo.Constructors;

class Day04DemoConstructor
{
    internal static void Test()
    {
        House h = new House(5, 5000);
        //h.Initialize(5, 50000);
        h.Build();

        // House h2 = new House(); // Will not work as parameters are needed
        House h2 = new House(10, 10000, ConsoleColor.Red, ConsoleColor.Black, ConsoleColor.Magenta);
    }
}
