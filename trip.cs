using System;
using System.Collections.Generic;

namespace Project
{
    public class Trip
    {
        private string destination;
        private int maxCapacity;

        private List<Ticket> bookedPassengers = new List<Ticket>();    //the 'list' helps us in counting the number of items inside the lists

        public Trip(string dest, int capacity)
        {
            destination = dest;
            maxCapacity = capacity;
        }

        //booking logic
        public void AddTicket(Ticket myTicket)
        {
            //CHECK FOR DUPLICATE SEAT FIRST 
            foreach(Ticket t in bookedPassengers)
            {
                if(t.SeatNumber == myTicket.SeatNumber)
                {
                    Console.WriteLine("Sorry, The Seat " + t.SeatNumber + " Is Already Taken.");
                    return; 
                }
            }


            // CHECK CAPACITY
            if(bookedPassengers.Count >= maxCapacity)    // we can know the count of the passengers becuase we used the 'list' keyword
            {
                Console.WriteLine("ERROR! The Trip to " + destination + " Is Full!");
                return;    //stop the program here
            }
            else
            {
                bookedPassengers.Add(myTicket);
                Console.WriteLine("Booking Confirmed For " + myTicket.PassengerName);
                myTicket.printTicketInfo();
            }
        }
    
    }
}