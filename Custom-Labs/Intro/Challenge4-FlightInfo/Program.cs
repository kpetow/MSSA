/*
Write a program that can tell:
    - The information of every passenger in a flight
    - How many passengers are in the flight
    - How many seats in the airplane are empty
    - The origin and destination of the flight
*/


Passenger pax1 = new Passenger ("Kevin", "Petow", "1A", 1234);
Passenger pax2 = new Passenger ("Mike", "Smith", "2B", 1234);
Passenger pax3 = new Passenger ("Dan", "Johnson", "5A", 1234);
Passenger pax4 = new Passenger ("Sam", "Adams", "4B", 1234);

Flight flight1 = new Flight(1234, 4, 10, "Seattle", "Chicago");
flight1.addToManifest(pax1.seat, pax1.lastname);
flight1.addToManifest(pax2.seat, pax2.lastname);
flight1.addToManifest(pax3.seat, pax3.lastname);
flight1.addToManifest(pax4.seat, pax4.lastname);

Console.Write("Flight Lookup. Enter a flight number (use 1234):");
int searchNo = int.Parse(Console.ReadLine());

if(searchNo == flight1.flightNo)
{
    foreach (KeyValuePair pax in flight1.)
    {
        Console.WriteLine ($"{pax.seat} - {pax.lastname}");
    }
}


//Console.WriteLine ($"Passenger Info:\nName: {pax1.firstname} {pax1.lastname}\nSeat: {pax1.seat}\nFlight #{pax1.flightNo}\n");

//Console.WriteLine($"Flight Info\nFlight Number #{flight1.flightNo}\nPassenger Count: {flight1.paxCount}\nSeats Remaining: {flight1.paxCapacity - flight1.paxCount}\nOrigin: {flight1.origin}\nDestination: {flight1.destination}\n");
