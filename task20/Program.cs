public class Storage
{
    double value = 3.14;

    public void setValue(double val)
    {
        value = val;
    }

    public double getValue()
    {
        return value;
    }
}

static class Runtime
{
    public static void Main()
    {
        Storage str = new Storage();
        Console.WriteLine(str.getValue());
        str.setValue(15.35);
        Console.WriteLine(str.getValue());
    }

}