using Genericss;
Console.WriteLine("Welcome to generics problem");
Console.WriteLine("Enter value 1");
int A =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value 2");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value 3");
int C = Convert.ToInt32(Console.ReadLine());
maximum<int> maxim = new maximum<int>(A, B, C);
maxim.max();
maximum<string> str = new maximum<string>("Hey", "Hold", "On");     //to check for string values in the same generic class
str.max();
maximum<double> doub = new maximum<double>(0.123, 1.267, 1.268);     //to check for float or double values in the same generic class
doub.max();