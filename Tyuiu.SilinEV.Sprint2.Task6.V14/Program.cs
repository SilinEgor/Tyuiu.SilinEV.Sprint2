using Tyuiu.SilinEV.Sprint2.Task6.V14.Lib;

DataService ds = new();
int q = Convert.ToInt32(Console.ReadLine());
int w = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ds.FindDayName(q, w));