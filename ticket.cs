using System;

namespace Project
{
    public class Ticket
    {
        //public so other classes can read them but private set so they can't be changed
        public string PassengerName{get; private set ;}  //field
        public string SeatNumber{get; private set;}   // string beacuse plane seats have both letters and numbers
          
          
        //constructor
        public Ticket(string name, string seat)
        {
            PassengerName = name;
            SeatNumber = seat;
        } 
        public void printTicketInfo()  // method
        {
            Console.WriteLine("Passenger Name: " + PassengerName);
            Console.WriteLine("Seat Number: " + SeatNumber);
        }
    }
}