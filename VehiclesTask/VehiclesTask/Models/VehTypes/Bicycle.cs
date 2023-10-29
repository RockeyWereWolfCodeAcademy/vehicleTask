using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Models.VehParts;

namespace VehiclesTask.Models.VehTypes
{
    internal class Bicycle : Vehicle, IWheel
    {
        public string PedalKind { get; set; }
        public int WheelThickness { get; set; }

        public Bicycle(double drivePath, double driveTime, int wheelThickness, string pedalKind) : base(drivePath, driveTime)
        {
            WheelThickness = wheelThickness;
            PedalKind = pedalKind;
        }

        public override string ToString()
        {
            return $" {base.ToString().Remove(0, 29)}" +
                $"\nMileage: {DrivePath} km" +
                $"\nThe mileage was completed in {DriveTime} hours" +
                $"\nAverage speed on this path is {AverageSpeed()} km/h" +
                $"\nWheel thickness: {WheelThickness} mm" +
                $"\nPedal Kind: {PedalKind}";
        }
    }
}
