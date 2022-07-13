using System;
using System.IO;
namespace task1;

static class Runtime
{
    static void Main()
    {
        //Input Method choice
        StreamReader reader = new StreamReader("task1.txt");
        string[] parse = reader.ReadLine().Split(' ');
        //string[] parse = Console.ReadLine().Split(' ');
        
        double A1 = Convert.ToDouble(parse[0]);
        double A2 = Convert.ToDouble(parse[1]);
        double A3 = Convert.ToDouble(parse[2]);
        double A4 = Convert.ToDouble(parse[3]);
        double A5 = Convert.ToDouble(parse[4]);

        double bef_sqrt = Math.Round(A1/A3,5);
        //DEBUG
        Console.WriteLine("A1/A3: "+bef_sqrt);
        //
        
        double aft_sqrt = Math.Round(Math.Sqrt(bef_sqrt),5);
        //DEBUG
        Console.WriteLine("Sqrt(A1/A3): "+aft_sqrt);
        //
        
        double aft_lin = Math.Round(Math.Log(A5),5);
        //DEBUG
        Console.WriteLine("ln(A5): "+aft_lin);
        //

        double aft_pow = Math.Round(Math.Pow(A4,A5),5);
        //DEBUG
        Console.WriteLine("A4^A5: "+aft_pow);
        //

        double aft_sin = Math.Round(Math.Sin(A2),5);
        //DEBUG
        Console.WriteLine("sin(A2): "+aft_sin);
        //

        double aft_tan = Math.Round(Math.Tan(Math.Round(A2-A4,5)),5);
        //DEBUG
        Console.WriteLine("tan(A2-A4): "+aft_tan);
        //

        double aft_dev = Math.Round(A1/A3,5);
        //DEBUG
        Console.WriteLine("A1/A3: "+aft_dev);
        //

        double pre_pow = Math.Round(aft_tan/aft_dev,5);
        //DEBUG
        Console.WriteLine("tan(A2-A4)/(A1/A3): "+pre_pow);
        //

        double aft_pow2 = Math.Round(Math.Pow(aft_sin,pre_pow),5);
        //DEBUG
        Console.WriteLine("sin(A2)^(tan(A2-A4)/(A1/A3)): "+aft_pow2);
        //

        double res = Math.Round(Math.Round(Math.Round(aft_sqrt*aft_lin,5)-aft_pow,5)-aft_pow2,5);
        //DEBUG
        Console.WriteLine("res: "+res);
        //
        Console.WriteLine("RESULT: "+Math.Round(res,2));
    }
}
