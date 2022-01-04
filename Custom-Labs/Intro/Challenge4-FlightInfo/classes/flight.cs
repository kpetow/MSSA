public class Flight
{
    public int flightNo {get; set;}
    public int paxCount {get; set;}
    public int paxCapacity {get; set;}
    public string origin {get; set;}
    public string destination {get; set;}

    Dictionary<string, string> manifest = new Dictionary<string, string>();

    public Flight(int flightNo, int paxCount, int paxCapacity, string origin, string destination)
    {
        this.flightNo = flightNo;
        this.paxCount = paxCount;
        this.paxCapacity = paxCapacity;
        this.origin = origin;
        this.destination = destination;
    }

    public void addToManifest(string seat, string lastname)
    {
        manifest.Add(seat, lastname);
    }
}