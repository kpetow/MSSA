
public class Passenger
{
    public string firstname {get; set;}
    public string lastname {get; set;}
    public string seat {get; set;}
    public int flightNo {get; set;}

    public Passenger(string firstname, string lastname, string seat, int flightNo)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.seat = seat;
        this.flightNo = flightNo;
    }

    public void setPassenger()
    {

    }

    public string getPassenger()
    {
        return this.lastname;
    }

}
