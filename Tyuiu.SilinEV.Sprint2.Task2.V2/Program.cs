using Tyuiu.SilinEV.Sprint2.Task2.V2.Lib;

DataService ds = new();

int q = Convert.ToInt32(Console.ReadLine());
int w = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ds.CheckDotInShadedArea(q, w));