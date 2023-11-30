using TriangleTypeDetector;

Console.WriteLine("Enter 3 lines of triangle:");

var firstLineLength = InputLineLength("1st");
Console.WriteLine();

var secondLineLength = InputLineLength("2nd");
Console.WriteLine();

var thirdLineLength = InputLineLength("3rd");
Console.WriteLine();

var isValidTriangle = TriangleManager.Validate(firstLineLength, secondLineLength, thirdLineLength);

if (isValidTriangle)
{
    var triangleType = TriangleManager.DetectTriangleType(firstLineLength, secondLineLength, thirdLineLength);
    Console.WriteLine($"Triangle is {triangleType}");
}
else
{
    Console.WriteLine("Impossible to create a triangle from entered lines");
}

Console.ReadKey();


static double InputLineLength(string lineName)
{
    Console.WriteLine($"{lineName} line:");
    var input = Console.ReadLine();
    double lineLength;

    while (!double.TryParse(input, out lineLength))
    {
        Console.WriteLine("Invalid input. Please try again and enter a number:");
        input = Console.ReadLine();
    }

    return lineLength;
}
