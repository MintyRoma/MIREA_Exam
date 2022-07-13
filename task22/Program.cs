using System;
using System.IO;
namespace task;

public static class Runtime
{
    public static void Main()
    {
        StreamReader reader  = new StreamReader("task.txt");
        string info = reader.ReadLine();
        string[] parsed = info.Split(' ');
        int M = Convert.ToInt32(parsed[0]);
        int N = Convert.ToInt32(parsed[1]);
        int Koma = Convert.ToInt32(parsed[2]);
        int[,] data = new int[M,N];
        for (int i =0; M>i; i++)
        {
            string[] strokes = reader.ReadLine().Split(' ');
            int[] got = Array.ConvertAll(strokes,int.Parse);
            for(int ak = 0; ak<N; ak++)
            {
                data[i,ak] = got[ak];
                Console.Write(data[i,ak]+" ");
            }
            Console.Write("\n");
        }
        for (int command = 0; command<Koma;command++)
        {
            string[] strokes = reader.ReadLine().Split(' ');
            int[] param = Array.ConvertAll(strokes,int.Parse);
            data[param[0],param[1]]=param[2];
        }

        Console.WriteLine("DEBUG");
        long sum = 0;
        for (int i=0;i<M;i++)
        {
            for (int j = 0; j<N;j++)
            {
                sum+=data[i,j];
                Console.Write(data[i,j]+" ");
            }
            Console.Write('\n');
        }
        Console.WriteLine(sum);
    }
}