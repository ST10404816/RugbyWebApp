using NUnit.Framework;
using PassItOnAcademy.Models;
using System;

namespace RugbyWebApp.Tests
{
    public class BookingTests
    {
        [Test]
        public void Booking_ShouldLinkToSessionAndUser()
        {
            var session = new TrainingSession
            {
                Id = 1,
                Title = "Agility Practice",
                CoachId = "coach001",
                Price = 250m
            };

            var user = new ApplicationUser
            {
                Id = "user123",
                FullName = "John Doe"
            };

            var booking = new Booking
            {
                Id = 1,
                SessionId = session.Id,
                Session = session,
                UserId = user.Id,
                User = user,
                CreatedUtc = DateTime.UtcNow
            };

            Assert.That(booking.Session.Title, Is.EqualTo("Agility Practice"));
            Assert.That(booking.User.FullName, Is.EqualTo("John Doe"));
            Assert.That(booking.Status, Is.EqualTo(BookingStatus.Booked));
        }
    }
}
