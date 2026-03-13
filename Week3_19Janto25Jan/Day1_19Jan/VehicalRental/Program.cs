namespace VehicleRental
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\nAdd Car Details");
            Car car = new Car();

            Console.WriteLine("\nAdd Bike Details");
            Bike bike = new Bike();

            Console.WriteLine("\nAdd Truck Details");
            Truck truck = new Truck();

            Console.WriteLine("\n--- Available Vehicles ---");
            car.ShowDetails();
            bike.ShowDetails();
            truck.ShowDetails();

            Console.WriteLine("\nEnter Customer Details");
            Customer cust = new Customer();

            Console.WriteLine("\nRenting Car...");
            if (car.isAvailable)
            {
                RentalTransaction rent = new RentalTransaction(car, cust);
                rent.ShowBill();
                rent.ReturnVehicle();
            }

            Console.WriteLine("\nVehicle Returned Successfully!");
            Console.ReadLine();
        }
    }
}
