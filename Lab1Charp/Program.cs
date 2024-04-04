// See https://aka.ms/new-console-template for more information

 static void task1()
{
    Console.WriteLine("Task1 !");
    Console.Write("s= ");
    string? str = Console.ReadLine();
    float s = 0; 
    if (str != null) s = float.Parse(str);
    double p = 4 * Math.Sqrt(s);
    Console.WriteLine("p=" + p);

}
Console.WriteLine("Lab 1 !");
task1();
// continue ...
