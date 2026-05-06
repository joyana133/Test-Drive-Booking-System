using TestDriveBookingSystem;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Customer> customers = new List<Customer>();
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Staff> staffList = new List<Staff>();
        List<Booking> bookings = new List<Booking>();

        // Sample staff members
        staffList.Add(new Staff { Name = "Eva Smith", IsAvailable = true });
        staffList.Add(new Staff { Name = "Ebenezer Scrooge", IsAvailable = true });

        // Sample vehicles
        vehicles.Add(new Vehicle { Model = "Volkswagen Golf", Type = "Hatchback" });
        vehicles.Add(new Vehicle { Model = "MG HS", Type = "SUV" });

        // Create customer
        Customer customer = new Customer
        {
            Name = "Fredrick Pearson",
            Email = "pearson130@email.com",
            Address = "67 High Street",
            Phone = "0756234789",
            MissedScore = 0
        };

        customers.Add(customer);

        // Check if customer is banned
        if (customer.MissedScore >= 3)
        {
            Console.WriteLine("Customer is not able to book any more test drives.");
        }
        else
        {
            Staff selectedStaff = staffList[0];

            if (selectedStaff.IsAvailable == false)
            {
                Console.WriteLine("Staff member is unavailable.");
            }
            else
            {
                Booking booking = new Booking
                {
                    CustomerDetails = customer,
                    VehicleAssigned = vehicles[0],
                    StaffMember = selectedStaff,
                    DateTime = DateTime.Now,
                    Status = "Booked"
                };

                bookings.Add(booking);
                selectedStaff.IsAvailable = false;

                Console.WriteLine("Booking created successfully.");
                Console.WriteLine("Customer: " + booking.CustomerDetails.Name);
                Console.WriteLine("Vehicle: " + booking.VehicleAssigned.Model);
                Console.WriteLine("Staff: " + booking.StaffMember.Name);
                Console.WriteLine("Status: " + booking.Status);
            }
        }

        // Example missed booking logic
        if (bookings.Count > 0)
        {
            bookings[0].Status = "Missed";
            bookings[0].CustomerDetails.MissedScore++;

            Console.WriteLine();
            Console.WriteLine("Booking status updated to missed.");
            Console.WriteLine("Missed score: " + bookings[0].CustomerDetails.MissedScore);

            if (bookings[0].CustomerDetails.MissedScore >= 3)
            {
                Console.WriteLine("Customer cannot book further test drives.");
            }
        }
    }
}