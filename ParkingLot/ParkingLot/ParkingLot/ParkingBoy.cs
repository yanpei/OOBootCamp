namespace ParkingLot.Test
{
    public class ParkingBoy
    {
        ParkingLot ParkingLot;

        public ParkingBoy(ParkingLot packingLot)
        {
            ParkingLot = packingLot;
        }

        public string Park(Car car)
        {
            return ParkingLot.Park(car);
        }

        public Car Pick(string token)
        {
            return ParkingLot.Pick(token);
        }
    }
}