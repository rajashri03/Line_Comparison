/*
 * Line Comparison-
 * Compare of Two Lines
 */

int x1, x2, y1, y2, a1, a2, b1, b2;
Double FirstLine, SecondLine, length1, length2;
Console.WriteLine("**********-> Compare Two Lines <-**********");

//First Line Coordinates
Console.WriteLine("Enter values of the coordinates for first line(x1,y1,x2,y2)");
x1 = Convert.ToInt32(Console.ReadLine());
y1 = Convert.ToInt32(Console.ReadLine());
x2 = Convert.ToInt32(Console.ReadLine());
y2 = Convert.ToInt32(Console.ReadLine());

//Length of First Line

FirstLine = Math.Sqrt(Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)); //Calculating Length
length1 = Math.Round(FirstLine, 2);
Console.WriteLine("Length of the First line is: " + FirstLine);


//Second Line coordinates
Console.WriteLine("Enter values of the coordinates for second point(a1,b1,a2,b2)");
a1 = Convert.ToInt32(Console.ReadLine());
b1 = Convert.ToInt32(Console.ReadLine());
a2 = Convert.ToInt32(Console.ReadLine());
b2 = Convert.ToInt32(Console.ReadLine());

SecondLine = Math.Sqrt(Math.Pow(a2 - a1, 2)) + (Math.Pow(b2 - b1, 2)); //Calculating Length
length2 = Math.Round(SecondLine, 2);
Console.WriteLine("Length of the Second line is: " + length2);

int compare_value = length1.CompareTo(length2);

if (compare_value == 0)
{
    Console.WriteLine("Both  lines are equal\n\n");
}
else if (compare_value < 0)
{
    Console.WriteLine("First Line is less than Second Line\n\n");
}
else if (compare_value > 0)
{
    Console.WriteLine("First Line is Greater than Second Line\n\n");
}