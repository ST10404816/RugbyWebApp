using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.EntityFrameworkCore;
using PassItOnAcademy.Controllers;
using PassItOnAcademy.Data;
using System.Threading.Tasks;

namespace RugbyWebApp.Tests
{
    public class HomeControllerTests
    {
        [Test]
        public async Task Index_ReturnsViewResult()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("HomeControllerTestDB")
                .Options;

            using var db = new ApplicationDbContext(options);
            var logger = NullLogger<HomeController>.Instance;
            var controller = new HomeController(logger, db);

            var result = await controller.Index();
            Assert.That(result, Is.InstanceOf<ViewResult>());
        }
    }
}
