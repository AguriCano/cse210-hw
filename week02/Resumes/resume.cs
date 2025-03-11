public class Resume
{
    public string _personName;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Nombre: {_personName}");
        Console.WriteLine("Trabajos:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}