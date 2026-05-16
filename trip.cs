using System;
using System.Collections.Generic;

namespace Project
{
    public class Trip
    {
        public string destination {get; private set;}
        public int maxCapacity {get; private set;}
        private int depTime;

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
                myTicket.printTicketInfo();  //call the print info method to print information of the ticket if the trip is available
            }
        }
        public void showAvailableSeats()
        { 
            for(int i=1; i<=maxCapacity; i++)
            {
                bool isTaken = false;

                // check if the seat is booked
                foreach(Ticket t in bookedPassengers)
                {
                    if(t.SeatNumber == i.ToString())
                    {
                        isTaken = true;
                        break; // no need to look for the other tickets
                    }
                }
                // print the seat number if it's not taken
                if(!isTaken)
                {
                    Console.Write("seat " + i + " is available.");
                }
            }
            Console.WriteLine();
        }
    }
}