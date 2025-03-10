public class Resume{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        for(int i = 0; i < _jobs.Count ; i++)
        {
            Console.WriteLine($"{_jobs[i]._jobTittle} ({_jobs[i]._company}) {_jobs[i]._startYear}-{_jobs[i]._endYear}");
        }
    }
}