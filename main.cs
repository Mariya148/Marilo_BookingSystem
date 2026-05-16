using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Terminal myTerminal = new Terminal();

            while(true){
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("Welcome To The Terminal..");
                Console.WriteLine("What operation do you want to do?: ");
                Console.WriteLine("1. View Trips");
                Console.WriteLine("2. Book A Ticket");
                Console.WriteLine("3. Exit");
                Console.WriteLine("===================================");

                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1: 
                    // viewing trips
                        myTerminal.printAvailableTrips();  // print the available trips 
                        Console.WriteLine("Press any key to exit the program..");
                        Console.ReadKey();
                        break;
                    case 2:
                    // booking a ticket
                        {
                            Console.Write("Enter the Passenger's Name: ");
                            string inputName = Console.ReadLine();  //takes keyboard input

                            Console.Write("Enter Seat Number: ");
                            string inputSeat = Console.ReadLine();

                            //create a new ticket
                            Ticket myTicket = new Ticket(inputName, inputSeat);
                            Trip foundTrip = myTerminal.searchTrip();

                            if (foundTrip != null){
                            foundTrip.AddTicket(myTicket);
                            }

                            Console.WriteLine("Press any key to exit the program..");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}