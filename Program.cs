// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
byte b = 100;
int i = Convert.ToInt32(b);
// string s = "1234";
// int j = Convert.ToInt32(s);
// System.Console.WriteLine(j + 100);

try
{
    string s = "1234c";
    int j = Convert.ToInt32(s);
    System.Console.WriteLine(j + 100);
}
catch (System.Exception ex)
{
    System.Console.WriteLine("Not converted");  // TODO
}