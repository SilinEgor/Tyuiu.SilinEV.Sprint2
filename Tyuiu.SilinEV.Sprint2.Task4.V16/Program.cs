using Tyuiu.SilinEV.Sprint2.Task4.V16.Lib;

double q = Convert.ToDouble(Console.ReadLine());
double w = Convert.ToDouble(Console.ReadLine());
DataService ds = new();
Console.WriteLine(ds.Calculate(q, w));