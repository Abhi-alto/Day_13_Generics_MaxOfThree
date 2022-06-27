using Genericss;
Console.WriteLine("Welcome to generics problem");
int[] ar1 = new int[5] { 5, 456, 78, 34, 2 };
string[] ar2 = new string[4] { "Abhi","Mohit","Jason","Krishna"};
float[] ar3 = new float[7] { 5.67f,3.456f, 78.3f, 34.33f, 2.3f,0.45f,11.3f };

maximum<int> inte = new maximum<int>(ar1);
inte.sort();
inte.display();

Console.WriteLine("Maximum value is "+(inte.max()));
maximum<string> str = new maximum<string>(ar2);     //to check for string values in the same generic class
str.sort();
str.display();
Console.WriteLine("Maximum value is " + (str.max()));

maximum<float> doub = new maximum<float>(ar3);     //to check for float or double values in the same generic class
doub.sort();
doub.display();
Console.WriteLine("Maximum value is " + (doub.max()));
