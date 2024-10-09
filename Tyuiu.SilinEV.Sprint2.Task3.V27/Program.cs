using Tyuiu.SilinEV.Sprint2.Task3.V27.Lib;

DataService ds = new();
double q = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(ds.Calculate(q));