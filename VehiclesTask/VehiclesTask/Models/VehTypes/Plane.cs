using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Models.VehParts;

namespace VehiclesTask.Models.VehTypes
{
    internal class Plane : Vehicle, IEngine
    {
        public int WingLength { get; set; }
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        int _currentOil;
        public int CurrentOil
        {
            get => _currentOil;
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

        public Plane(double drivePath, double driveTime, int horsePower, int tankSize, int currentOil, string fuelType, int wingLength) : base(drivePath, driveTime)
        {
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
            FuelType = fuelType;
            WingLength = wingLength;
        }

        public override string ToString()
        {
            return $" {base.ToString().Remove(0, 29)}" +
                $"\nMileage: {DrivePath} km" +
                $"\nThe mileage was completed in {DriveTime} hours" +
                $"\nAverage Speed on this path is {AverageSpeed()} km/h" +
                $"\nHorse Power: {HorsePower} hp" +
                $"\nTank Size: {TankSize} litres" +
                $"\nCurrent Oil: {CurrentOil} litres" +
                $"\nFuel Type:  {FuelType}" +
                $"\nOil left for full tank: {RemainingOilAmount()} litres" +
                $"\nWing Length: {WingLength} meters";
        }
    }
}
