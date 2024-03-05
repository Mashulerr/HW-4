namespace hw3{

class DaysOfWeek : IPrint
{
    private static string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    public void Print()
    {
        foreach (string day in days)
        {
            Console.WriteLine(day);
        }
    }
}
}