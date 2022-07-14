using System;
using System.IO;
namespace task;

public static class Runtime
{
    public static void Main()
    {
        //For task.txt use generator!
        StreamReader reader = new StreamReader("task.txt");
        string[] info = reader.ReadLine().Split(' ');
        int flag = Convert.ToInt32(info[0]);
        int operations = Convert.ToInt32(info[1]);
        int position = 0;
        int counter =0;
        Console.WriteLine($"Flag: {flag}, Operations:{operations}");
        for (int i=0; i<operations;i++)
        {
            int command = Convert.ToInt32(reader.ReadLine());
            if (command<0)
            {
                if ((position+command<=flag)&&(position>flag)) counter++;
                position+=command;
            }
            if (command>0)
            {
                if ((position+command>=flag)&&(position<flag)) counter++;
                position+=command;
            }
            //DO NOT UNCOMMENT ON PRODUCTION!!!
            //Without logging program needs 5 secs. to calculate everything.
            //Console.WriteLine($"Step: {i+1}, Position: {position}, Counter: {counter}");
        }
        Console.WriteLine(counter);
    }
}
