namespace Day05Demo.Polymorphism
{
    class Box
    {
        int _x, _y;

        public Box(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // Polymorphism - Static Binding
        public void Show()
        {
            Console.WriteLine($"x={_x}, y={_y}");
        }

        // Polymorphism - Static Binding
        public void Show(ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine($"x={_x}, y={_y}");
            Console.ResetColor();
        }
    }
}
