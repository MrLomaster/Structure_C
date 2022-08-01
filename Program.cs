People one = new();
Console.WriteLine("Первый");
one.name = Console.ReadLine();
one.mark = Console.ReadLine();
Console.WriteLine("\t");

People two = new();
Console.WriteLine("Второй");
two.name = Console.ReadLine();
two.mark = Console.ReadLine();
Console.WriteLine("\t");

People three = new();
Console.WriteLine("Третий");
three.name = Console.ReadLine();
three.mark = Console.ReadLine();
Console.WriteLine("\t");

one.Print_All();
struct People
{
    public string name;
    public string mark;

    public void Print_Name() => Console.Write("{name}");
    public void Print_Mark() => Console.Write("{mark}");
    public void Print_All()
    {
        Console.Write(name + " ");
        Console.Write(mark);
    }

}