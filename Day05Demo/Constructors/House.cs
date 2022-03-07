// See https://aka.ms/new-console-template for more information

namespace Day05Demo.Constructors;
public class House
{
    private int _floors;
    private int _squareFeet;
    private ConsoleColor _outerColor;
    private ConsoleColor _balconyColor;
    private ConsoleColor _corridorColor;

    public House(int floors, int squareFeet)
    {
        _floors = floors;
        _squareFeet = squareFeet;
        _outerColor = ConsoleColor.Green;
        _balconyColor = ConsoleColor.White;
        _corridorColor = ConsoleColor.Yellow;
    }

    // Overloading constructor
    public House(int floors, int squareFeet, ConsoleColor outercolor, ConsoleColor balconyColor, ConsoleColor corridorColor)
    {
        _floors = floors;
        _squareFeet = squareFeet;
        _outerColor = outercolor;
        _balconyColor = balconyColor;
        _corridorColor = corridorColor;
    }

    /*
    // This is not a good way to create a separate method to initialize data.
    // Instead create a constructor
    public void Initialize(int floors, int squareFeet)
    {
        _floors = floors;
        _squareFeet = squareFeet;
        outerColor = ConsoleColor.Green;
        balconyColor = ConsoleColor.White;
        corridorColor = ConsoleColor.Yellow;
    }
    */
    internal void Build()
    {

    }
}