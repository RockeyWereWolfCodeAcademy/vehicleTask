using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesTask.Models
{
    abstract class Vehicle
    {
        public double DriveTime { get; set; }
        public double DrivePath { get; set;}
        public double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public Vehicle(double drivePath, double driveTime)
        {
            DrivePath = drivePath;
            DriveTime = driveTime;
        }
    }
}
