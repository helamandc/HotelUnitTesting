using HotelUnitTesting.Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //Arrange
            Reservation myReservation = new Reservation();
            //Act
            var result = myReservation.CanBeCancelledBy(new User { IsAdmin = true});
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_MadeByUser_ReturnTrue()
        {
            //Arrange
            var user = new User();
            Reservation myReservation = new Reservation { MadeBy = user };
            //Act
            var result = myReservation.CanBeCancelledBy(user);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_OtherUser_ReturnFalse()
        {
            //Arrange
            var user = new User();
            Reservation myReservation = new Reservation();
            //Act
            var result = myReservation.CanBeCancelledBy(user);
            //Assert
            Assert.IsFalse(result);
        }
    }
}