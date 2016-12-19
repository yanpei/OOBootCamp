using Xunit;

namespace ParkingLot.Test
{
    public class ParkingLotFacts
    {
        [Fact]
        public void should_be_able_to_park_a_car_and_pick_the_car()
        {
            Car car = new Car(1);
            ParkingLot parkingLot = new ParkingLot(1);

            var token = parkingLot.Park(car);

            Assert.Same(car,parkingLot.Pick(token));
        }

        [Fact]
        public void should_be_able_to_park_multiple_cars_and_pick_consistent_car_according_to_token()
        {
            Car car1 = new Car(1);
            Car car2 = new Car(2);
            ParkingLot parkingLot = new ParkingLot(2);

            var token1 = parkingLot.Park(car1);
            var token2 = parkingLot.Park(car2);

            Assert.Same(car1, parkingLot.Pick(token1));
            Assert.Same(car2, parkingLot.Pick(token2));
        }

        [Fact]
        public void should_not_able_to_park_a_car_when_given_a_full_parking_lot()
        {
            Car car1 = new Car(1);
            Car car2 = new Car(2);
            ParkingLot parkingLot = new ParkingLot(1);
            parkingLot.Park(car1);

            Assert.Equal(null, parkingLot.Park(car2));
        }

        [Fact]
        public void should_not_able_to_pick_the_car_when_a_car_not_exist_in_parking_lot()
        {
            Car car = new Car(1);
            ParkingLot parkingLot = new ParkingLot(1);
            var token = car.CarNumber.ToString();

            Assert.Same(null, parkingLot.Pick(token));
        }

        [Fact]
        public void should_not_able_to_pick_the_car_when_parked_a_car_and_already_picked_the_car()
        {
            Car car = new Car(1);
            ParkingLot parkingLot = new ParkingLot(1);
            var token = parkingLot.Park(car);
            parkingLot.Pick(token);

            Assert.Same(null, parkingLot.Pick(token));
        }
    }
}
