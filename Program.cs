//Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        //promting the user to input a value for the length and width of the room as well as height
        Console.WriteLine("Please input the length of the room ");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Please input the width of the room ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Please input the height of the room ");
        double height = double.Parse(Console.ReadLine());
        //displaying to the user the length and width of the room
        Console.WriteLine("The length of the room is " + length + ". The width of the room is " + width + ".");
        //calculating the area and perimeter of the room under the variables "area" and "perimeter"
        double area = length * width;
        double perimeter = 2 * width + 2 * length;
        Console.WriteLine("The perimeter of the room is " + perimeter + ". The area of the room is " + area + ".");
        //calculating and displaying the volume and surface areas of the room 
        double volume = length * width * height;
        double surarea = 2 * (width * length + height * length + height * width);
        Console.WriteLine("The volume of the room is " + volume + ". The surface area of the room is " + surarea + ".");
        if (area <= 250 && area > 0)
        {
            Console.WriteLine("The room is classified as small.");
        }
        else if (area < 650 && area > 250)
        {
            Console.WriteLine("The room is classified as medium.");
        }
        else
        {
            Console.WriteLine("The room is classified as large.");
        }
    }
}