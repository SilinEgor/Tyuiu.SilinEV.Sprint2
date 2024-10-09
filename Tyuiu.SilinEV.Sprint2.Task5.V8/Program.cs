using Tyuiu.SilinEV.Sprint2.Task5.V8.Lib;

DataService ds = new();
int q = Convert.ToInt32(Console.ReadLine()), w = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ds.FindDateOfPreviousDay(w, q));