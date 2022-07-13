using System;
using System.IO;

namespace task;

public static class Runtime
{
    public static void Main()
    {
        int startpoint = 1;

        StreamReader reader = new StreamReader("task.txt");
        while(!reader.EndOfStream)
        {
            string command = reader.ReadLine();
            if (command.Contains('+'))
            {
                int num = Convert.ToInt32(command.Substring(1));
                startpoint+=num;
            }
            else if (command.Contains('-'))
            {
                int num = Convert.ToInt32(command.Substring(1));
                startpoint-=num;
            }
            else if (command.Contains('*'))
            {
                int num = Convert.ToInt32(command.Substring(1));
                startpoint*=num;
            }
            else if (command.Contains('/'))
            {
                int num = Convert.ToInt32(command.Substring(1));
                startpoint/=num;
            }
        }
        Console.WriteLine(startpoint); 
    }
}