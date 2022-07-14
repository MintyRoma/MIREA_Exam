using System;
using System.IO;
namespace Task;
public static class Runtime
{
    public static void Main()
    {
        long ops = 70000000;
        StreamWriter writer = new StreamWriter("task.txt");
        writer.WriteLine("900 70000000");
        Random gen = new Random();
        while (ops!=0)
        {
            int data = gen.Next(-100000,100000);
            writer.WriteLine(data);
            //System.Threading.Thread.Sleep(7);
            ops--;
        }
    }
}