using Tyuiu.SilinEV.Sprint2.Task7.V12.Lib;

DataService ds = new();
double x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(ds.CheckDotInShadedArea(x, y));