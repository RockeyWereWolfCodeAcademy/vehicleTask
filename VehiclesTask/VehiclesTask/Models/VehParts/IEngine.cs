using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesTask.Models.VehParts
{
    internal interface IEngine
    {
        int HorsePower { get; set; }
        int TankSize { get; set; }
        int CurrentOil { get; set; }
        string FuelType { get; set; }

        int RemainingOilAmount();
    }
}
