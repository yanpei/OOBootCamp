using System.Collections.Generic;
using System.Linq;
using ParkingLot.Test;

namespace ParkingLot
{
    public class ParkingLot
    {
        readonly List<Car> carsList = new List<Car>();
        int Capacity { get; }

        public ParkingLot(int capacity)
        {
            Capacity = capacity;
        }

        public string Park(Car car)
        {
            if (carsList.Count < Capacity)
            {
                carsList.Add(car);
                return car.CarNumber.ToString();
            }
            return null;
        }

        public Car Pick(string token)
        {
            var pickedCar = carsList.FirstOrDefault(car => car.CarNumber == long.Parse(token));
            carsList.Remove(pickedCar);
            return pickedCar;
        }
    }
}
