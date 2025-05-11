public class Resume
{
    public string _FirstName;
    public string _LastName;
    public List<Job> _Jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_FirstName} {_LastName}");
        Console.WriteLine($"Jobs: ");
        foreach (Job job in _Jobs)
        {
            job.Display();
        }
    }
}