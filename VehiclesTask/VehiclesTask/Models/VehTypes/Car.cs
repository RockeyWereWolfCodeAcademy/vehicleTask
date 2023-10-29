using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Models.VehParts;

namespace VehiclesTask.Models.VehTypes
{
    internal class Car : Vehicle, IEngine, IWheel, ITransmission
    {
        public int DoorCount { get; set; }
        public string WinCode { get; set; }
        public string TransmissionKind {get; set; }
        public int WheelThickness { get; set; }
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        int _currentOil;
        public int CurrentOil { get => _currentOil; 
            set 
            {
                if (value > TankSize)
                {
                    Console.Write("Tank cant hold this amount of oil. Please enter oil amount again: ");
                    CurrentOil = int.Parse(Console.ReadLine());
                    return;
                }
                _currentOil = value;
            } 
        }
        public string FuelType { get; set; }
        public int RemainingOilAmount()
        {
            return TankSize - CurrentOil;
        }

        public override string ToString()
        {
            return $" {base.ToString().Remove(0, 29)}" +
                $"\nMileage: {DrivePath} km" +
                $"\nThe mileage was completed in {DriveTime} hours" +
                $"\nAverage Speed on this path is {AverageSpeed()} km/h" +
                $"\nDoor Count: {DoorCount}" +
                $"\nTransmission Kind: {TransmissionKind}" +
                $"\nWheel Thickness: {WheelThickness} cm" +
                $"\nHorse Power: {HorsePower} hp" +
                $"\nTank Size: {TankSize} litres" +
                $"\nCurrent Oil: {CurrentOil} litres" +
                $"\nFuel Type:  {FuelType}" +
                $"\nOil left for full tank: {RemainingOilAmount()}";
        }

        public Car(double drivePath, double driveTime, int doorCount, string transmission, int wheelThickness, int horsePower, int tankSize, int currentOil, string fuelType) :base(drivePath, driveTime)
        {
            DoorCount = doorCount; 
            TankSize = tankSize; 
            CurrentOil = currentOil; 
            FuelType = fuelType; 
            TransmissionKind = transmission; 
            WheelThickness = wheelThickness; 
            HorsePower = horsePower;
        }
    }
}
