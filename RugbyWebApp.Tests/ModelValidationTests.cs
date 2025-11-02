using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PassItOnAcademy.Models;

namespace RugbyWebApp.Tests
{
    public class ModelValidationTests
    {
        private static IList<ValidationResult> Validate(object model)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, context, results, true);
            return results;
        }

        [Test]
        public void TrainingSession_MissingRequiredFields_ShouldFailValidation()
        {
            var session = new TrainingSession(); // Title & CoachId are [Required]
            var results = Validate(session);
            Assert.That(results.Count, Is.GreaterThan(0));
        }

        [Test]
        public void TrainingSession_ValidData_ShouldPassValidation()
        {
            var session = new TrainingSession
            {
                Title = "Passing Drills",
                CoachId = "coach123",
                Price = 200m,
                Capacity = 10
            };
            var results = Validate(session);
            Assert.That(results, Is.Empty);
        }
    }
}
