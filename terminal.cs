using System;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace Project
{
    public class Terminal
    {
        private List<Trip> myTrip = new List<Trip>();
        
        // example trips ( for now )

        public Terminal()  // constructor
        {
            myTrip.Add(new Trip("Ankara", 40));
            myTrip.Add(new Trip("Istanbul", 60));
            myTrip.Add(new Trip("Trabzon", 20));
        }
        public void printAvailableTrips()
        {
            foreach(Trip t in myTrip)
            {
                Console.WriteLine(t.destination);
                Console.WriteLine(t.maxCapacity);
            }
        }
        public Trip searchTrip()  // this method returns a Trip object
        {
            Console.Write("Choose your destiantion: ");
            Console.WriteLine("Istanbul, Ankara, Trabzon"); // use this logic for now
            string dest_input = Console.ReadLine();

            // loop through the trips to look for destination
            foreach(Trip t in myTrip)
            {
                if(t.destination == dest_input)
                {
                    return t;
                }
            } 
            return null;
        }
    }
}