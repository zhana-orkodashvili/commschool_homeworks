namespace week9_hw;

public class Student2
{
    private string name;
    
    public Student2(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public virtual void Study()
    {
        Console.WriteLine($"{name} is studying.");
    }

    public virtual void Read()
    {
        Console.WriteLine($"{name} is reading.");
    }

    public virtual void Write()
    {
        Console.WriteLine($"{name} is writing.");
    }

    public virtual void Relax()
    {
        Console.WriteLine($"{name} is relaxing.");
    }
    
    
}


public class GoodStudent : Student2
{
    public GoodStudent(string name) : base(name)
    {
    }

    public override void Study()
    {
        Console.WriteLine($"{Name} is studying well.");
    }
    
    public override void Read()
    {
        Console.WriteLine($"{Name} is reading carefully.");
    }
    
    public override void Write()
    {
        Console.WriteLine($"{Name} is writing neatly.");
    }
    
    public override void Relax()
    {
        Console.WriteLine($"{Name} isn't relaxed.");
    }
    
    
}

public class LazyStudent : Student2
{
    public LazyStudent(string name) : base(name)
    {
    }

    public override void Study()
    {
        Console.WriteLine($"{Name} isn't studying.");
    }
    public override void Read()
    {
        Console.WriteLine($"{Name} isn't into reading.");
    }
    
    public override void Write()
    {
        Console.WriteLine($"{Name} isn't often writing.");
    }
    
    public override void Relax()
    {
        Console.WriteLine($"{Name} is relaxing well.");
    }
}
