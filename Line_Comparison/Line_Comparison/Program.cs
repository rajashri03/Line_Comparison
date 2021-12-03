/*
 * Line Comparison-
 * Calculate Length of Line
 */

int x1, x2, y1, y2;
Double length,len;
Console.WriteLine("**********-> Calculate Length of Line <-**********");
Console.WriteLine("Enter values of the coordinates for first point(x1,y1)");
x1 = Convert.ToInt32(Console.ReadLine());
y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter values of the coordinates for second point(x2,y2)");
x2 = Convert.ToInt32(Console.ReadLine());
y2 = Convert.ToInt32(Console.ReadLine());
length =Math.Sqrt(Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)); //Calculating Length
len = Math.Round(length, 2);
Console.WriteLine("Length of the line is: " + length);
