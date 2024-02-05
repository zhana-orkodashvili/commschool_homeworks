namespace week10_hw;

public class TextualFileWorker: FileWorker
{
    private string fileExtension;

    public override string FileExtension
    {
            get => fileExtension;  
            set => fileExtension = value;
    }

    public TextualFileWorker(int maxFileSize, string fileExtension)
    { 
            MaxSize = maxFileSize;
            FileExtension = fileExtension;
    }

    public override void Read()
    {
            Console.Write("I can read from ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{FileExtension} ");
            Console.ResetColor();
            Console.Write($"file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{MaxSize}");
            Console.ResetColor();
            Console.WriteLine();
    }

    public override void Write()
    {
            Console.Write("I can write in ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{FileExtension} ");
            Console.ResetColor();
            Console.Write($"file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{MaxSize}");
            Console.ResetColor();
            Console.WriteLine();
    }

    public override void Edit()
    {
            Console.Write("I can edit ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{FileExtension} ");
            Console.ResetColor();
            Console.Write($"file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{MaxSize}");
            Console.ResetColor();
            Console.WriteLine();
    }

    public override void Delete()
    {
            Console.Write("I can delete from ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{FileExtension} ");
            Console.ResetColor();
            Console.Write($"file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{MaxSize}");
            Console.ResetColor();
            Console.WriteLine();
    }
}