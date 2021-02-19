using System;

class Singleton
{
    private static Singleton instance;
    static byte status = 3;

    private Singleton()
    {
        
    }
    public void SetStatus(byte st)
    {
        status = st;
    }

    public static Singleton getInstance()
    {
        if (instance == null)
            instance = new Singleton();
        return instance;
    }
    public void message(string mess)
    {
        if (status == 0 || status == 3) Console.WriteLine("ALERT " + mess);
        if (status == 1 || status == 3) Console.WriteLine("WARNING " + mess);
        if (status == 2 || status == 3) Console.WriteLine("MESSAGE " + mess);
    }

}




namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton ada = Singleton.getInstance();
            ada.message("Ya umer");
        }
    }
}
