using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace VehiclesTask.Models
{
    internal class VehicleList
    {
        Vehicle[] _array;

        public void Add(Vehicle vehicle)
        {
            Array.Resize(ref _array, _array.Length + 1);
            _array[_array.Length - 1] = vehicle;
        }

        public void Add(params Vehicle[] vehicles)
        {
            int oldLength = _array.Length;
            Array.Resize(ref _array, _array.Length + vehicles.Length);
            for (int i = oldLength; i < _array.Length; i++)
            {
                _array[i] = vehicles[i - oldLength];
            }
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < _array.Length)
            {
                Vehicle[] newArray = new Vehicle[_array.Length - 1];
                Array.Copy(_array, 0, newArray, 0, index);
                Array.Copy(_array, index + 1, newArray, index, _array.Length - index - 1);
                _array = newArray;
            }
            else
            {
                Console.WriteLine("Invalid index. Vehicle not removed.");
            }
        }

        public Vehicle[] GetAll()
        {
            return _array;
        }

        public void Print()
        {
            //Console.WriteLine(GetAll());
            for (int i = 0; i < _array.Length; i++)
            {
                //Console.Write(i + ", ");
                Console.WriteLine($"\nVehicle №{i+1}:"+_array[i]);
                //if (_array[i] != _array[_array.Length - 1])
                //{
                //    Console.Write(", ");
                //}
            }
        }

        public VehicleList(params Vehicle[] vehicles)
        {
            _array = new Vehicle[vehicles.Length];
            for (int i = 0; i < vehicles.Length; i++)
            {
                _array[i] = vehicles[i];
            }
        }
    }
}