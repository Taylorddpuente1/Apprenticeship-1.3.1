
using System
    class Program
{ 
    static void Main()
    { 
do
{

    Console.WriteLine("Welcome to calculator!");
    Console.WriteLine("Please select the shape you wouuld like to calculate the area for");


    Console.WriteLine("S: Square");
    Console.WriteLine("T: Triangle");
    Console.WriteLine("R: Rectangle");


    switch (Console.ReadLine())
    {
        case "S":
            SquareArea();
            break;


        case "T":
            TriangleArea();
            break;


        case "R":
            RectangleArea();
            break;

        default:
            Console.WriteLine("sorry, that is not an option (calculator is case sensative)");
            break;


    }
    Console.WriteLine("Would you like to continue?"(Y = Yes please! N = No):");
        } while (Console.ReadLine() == "y");

Console.WriteLine("Thank you, Goodbye!");











    }
}
