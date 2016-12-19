using Xunit;

namespace ParkingLot.Test
{
    public class ParkingBoyFacts
    {
        [Fact]
        public void should_park_a_car_and_pick_a_car_from_parking_lot_given_a_parking_lot()
        {
            ParkingLot parkingLot = new ParkingLot(1);
            ParkingBoy parkingBoy = new ParkingBoy(parkingLot);
            Car car =new Car(1);

            var token = parkingBoy.Park(car);

            Assert.Same(car, parkingBoy.Pick(token));
        }
    }
}
