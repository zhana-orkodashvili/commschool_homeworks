namespace week11_hw;

public class Birthday
{
    public DateTime CurrentDate { get; set; }
    public DateTime BirthDate { get; set; }

    public Birthday(DateTime currentDate, DateTime birthDate)
    {
        CurrentDate = currentDate;
        BirthDate = birthDate;
    }
}