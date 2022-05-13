class Program
{
    int i;
    public  void display()
    {
        Console.WriteLine("first");
    }
    static void Main()
    {
        Program p = new Program();
        p.i = 20;
        p.display();
        Console.ReadLine();
    }

}
