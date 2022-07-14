using System;
using System.IO;
namespace task;

public static class Runtime
{
    public static void Main()
    {
        StreamReader reader = new StreamReader("task.txt");
        List<string> rows = new List<string>();
        while(!reader.EndOfStream)
        {
            rows.Add(reader.ReadLine());
        }
        int heigth = rows.Count;
        int width = rows[0].Length;
        Console.WriteLine(heigth);
        Console.WriteLine(width);
        char[,] cave = new char[width,heigth];
        for (int y=0;y<heigth;y++)
        {
            for(int x=0;x<width;x++)
            {
                cave[x,y] = rows[y].ToCharArray()[x];
                Console.Write(cave[x,y]);
            }
            Console.Write("\n");
        }
        int summ = 0;
        for(int x = 0; x<width; x++)
        {
            int y = heigth-1;
            while(cave[x,y]!=' ')
            {
                y--;
                summ++;
            }
        }
        Console.WriteLine(summ);
    }
}
