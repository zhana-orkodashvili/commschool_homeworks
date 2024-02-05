namespace week10_hw;

public abstract class FileWorker
{
    private int maxSize;

    public int MaxSize
    {
        get => maxSize;
        set => maxSize = value;
    }

    public abstract string FileExtension { get; set; }

    public abstract void Read();
    public abstract void Write();
    public abstract void Edit();
    public abstract void Delete();
    
}