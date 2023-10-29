using System.IO;
using System.Xml.Serialization;
using VehiclesTask.Models;
using VehiclesTask.Models.VehTypes;

namespace VehiclesTask
{
    internal class Program
    {

        static  VehicleList vehicles = new();

        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("\n1 - Create a new Car");
                Console.WriteLine("2 - Create a new Bicycle");
                Console.WriteLine("3 - Create a new Plane");
                Console.WriteLine("4 - View all vehicles");
                Console.WriteLine("5 - Delete Vehicle");
                Console.WriteLine("6 - Exit");

                Console.Write("\nEnter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateCar();
                        break;
                    case 2:
                        CreateBicycle();
                        break;
                    case 3:
                        CreatePlane();
                        break;
                    case 4:
                        vehicles.Print();
                        break;
                    case 5:
                        Console.Write("Which vehicle to remove?(enter a № of veh)");
                        vehicles.Remove(int.Parse(Console.ReadLine())-1);
                        break;
                    case 6:
                        choice = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CreatePlane()
        {
            Console.Write("Enter mileage of this plane(km): ");
            double drivePath = double.Parse(Console.ReadLine());

            Console.Write("Enter time passed on this mileage(hours): ");
            double driveTime = double.Parse(Console.ReadLine());

            Console.Write("Enter horse power of this plane: ");
            int horsePower = int.Parse(Console.ReadLine());

            Console.Write("Enter max oil amount of this plane tank(litres): ");
            int tankSize = int.Parse(Console.ReadLine());

            Console.Write("Enter current oil amount in tank: ");
            int currentOil = int.Parse(Console.ReadLine());

            Console.Write("Enter fuel type of this plane: ");
            string fuelType = Console.ReadLine();

            Console.Write("Enter  wing length for this plane: ");
            int wingLength = int.Parse(Console.ReadLine());

            vehicles.Add(new Plane(drivePath, driveTime, horsePower, tankSize, currentOil, fuelType, wingLength));
        }

        static void CreateBicycle()
        {
            Console.Write("Enter mileage of this bike(km): ");
            double drivePath = double.Parse(Console.ReadLine());

            Console.Write("Enter time passed on this mileage(hours): ");
            double driveTime = double.Parse(Console.ReadLine());

            Console.Write("Enter thickness of this bike wheels(mm): ");
            int wheelThickness = int.Parse(Console.ReadLine());

            Console.Write("Enter pedal kind of this bicycle: ");
            string pedalKind = Console.ReadLine();

            vehicles.Add(new Bicycle(drivePath, driveTime, wheelThickness, pedalKind));
        }

        static void CreateCar()
        {
            Console.Write("Enter mileage of this car(km): ");
            double drivePathCar = double.Parse(Console.ReadLine());

            Console.Write("Enter time passed on this mileage(hours): ");
            double driveTimeCar = double.Parse(Console.ReadLine());

            Console.Write("Enter door count of this car: ");
            int doorCount = int.Parse(Console.ReadLine());

            Console.Write("Enter type of transmission of this car: ");
            string transmission = Console.ReadLine();

            Console.Write("Enter thickness of this car wheels(cm): ");
            int wheelThicknessCar = int.Parse(Console.ReadLine());

            Console.Write("Enter horse power for this car: ");
            int horsePower = int.Parse(Console.ReadLine());

            Console.Write("Enter max oil amount of this car tank(litres): ");
            int tankSize = int.Parse(Console.ReadLine());

            Console.Write("Enter current oil amount in tank: ");
            int currentOil = int.Parse(Console.ReadLine());

            Console.Write("Enter fuel type of this car: ");
            string fuelType = Console.ReadLine();
            vehicles.Add(new Car(drivePathCar, driveTimeCar, doorCount, transmission, wheelThicknessCar, horsePower, tankSize, currentOil, fuelType));
        }
    }
}