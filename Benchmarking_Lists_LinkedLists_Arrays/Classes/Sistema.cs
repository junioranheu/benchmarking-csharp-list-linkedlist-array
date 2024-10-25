namespace Benchmarking_Lists_LinkedLists_Arrays.Classes
{
    public class Sistema
    {
        public Sistema()
        {
            GraphicsCards = new List<Video>();
        }

        public string? ProcessorName { get; set; }
        public uint NumberOfCores { get; set; }
        public double TotalMemoryGB { get; set; }
        public List<Video> GraphicsCards { get; set; }
    }

    public class Video
    {
        public string? Name { get; set; }
        public string? DriverVersion { get; set; }
    }
}