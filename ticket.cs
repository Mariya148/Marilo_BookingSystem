using System;

namespace Project
{
    public class Ticket
    {
        //public so other classes can read them but private set so they can't be changed
        public string PassengerName{get; private set;}  //field
        public string SeatNumber{get; private set;}   // string beacuse plane seats have both letters and numbers
          
          
        //constructor
        public Ticket(string name, string seat)
        {
            PassengerName = name;
            SeatNumber = seat;
        } 
        
        public string getPassengerName(){} // property
        public void printTicketInfo()  // method
        {
            Console.WriteLine("Passenger Name: " + PassengerName);
            Console.WriteLine("Seat Number: " + SeatNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Passenger's Name: ");
            string inputName = Console.ReadLine();  //takes keyboard input

            Console.Write("Enter Seat Number: ");
            string inputSeat = Console.ReadLine();

            //create a new ticket
            Ticket myTicket = new Ticket(inputName, inputSeat);

            //call the print info method
            myTicket.printTicketInfo();

            //this keeps the program opened until we press an exit button
            Console.WriteLine("Press any key to exit the program..");
            Console.ReadKey();

        }
    }
}