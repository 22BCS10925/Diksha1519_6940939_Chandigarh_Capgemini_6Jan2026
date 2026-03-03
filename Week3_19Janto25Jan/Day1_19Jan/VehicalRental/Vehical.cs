using System;
using System.Collections.Generic;
using System.Text;
using VehicleRental;


namespace VehicleRental
    {
        public abstract class Vehicle
        {
            public int vehicleId;
            public string brand;
            public bool isAvailable;

            public Vehicle()
            {
                Console.Write("Enter Vehicle ID: ");
                vehicleId = int.Parse(Console.ReadLine());

                Console.Write("Enter Brand Name: ");
                brand = Console.ReadLine();

                isAvailable = true;
            }

            public abstract double CalculateRent(int days);

            public void ShowDetails()
            {
                Console.WriteLine("ID: " + vehicleId +
                                  " Brand: " + brand +
                                  " Available: " + isAvailable);
            }
        }
    }

    public class Car : Vehicle
    {
        public Car() : base() { }

        public override double CalculateRent(int days)
        {
            return days * 1000;
        }
    }

    public class Bike : Vehicle
    {
        public Bike() : base() { }

        public override double CalculateRent(int days)
        {
            return days * 300;
        }
    }

    public class Truck : Vehicle
    {
        public Truck() : base() { }

        public override double CalculateRent(int days)
        {
            return days * 2000;
        }
    }

    public class Customer
    {
        public int customerId;
        public string customerName;

        
        public Customer()
        {
            Console.Write("Enter Customer ID: ");
            customerId = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            customerName = Console.ReadLine();
        }
    }
    public class RentalTransaction
    {
        private Vehicle rentedVehicle;
        private Customer customer;
        private int rentalDays;
        private double totalAmount;

        
        public RentalTransaction(Vehicle v, Customer c)
        {
            rentedVehicle = v;
            customer = c;

            Console.Write("Enter Number of Rental Days: ");
            rentalDays = int.Parse(Console.ReadLine());

            totalAmount = rentedVehicle.CalculateRent(rentalDays);
            rentedVehicle.isAvailable = false;
        }

        public void ReturnVehicle()
        {
            rentedVehicle.isAvailable = true;
        }

        public void ShowBill()
        {
            Console.WriteLine("Rental Bill");
            Console.WriteLine("Customer : " + customer.customerName);
            Console.WriteLine("Vehicle  : " + rentedVehicle.brand);
            Console.WriteLine("Days     : " + rentalDays);
            Console.WriteLine("Total ₹  : " + totalAmount);
        }
    }


