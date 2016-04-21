using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using WebApi.Controllers;

namespace WebApi.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new RsvpController();

            var get = controller.GetAttendees();
            Assert.IsTrue(get.Count > 0);

        }

        [TestMethod]
        public void TestMethod2()
        {
            var controller = new RsvpController();
            var response = new Models.GuestResponse() { Email = "abc@cde.com", Name = "Test Name", WillAttend = false };
            controller.HebeleHubele(response);
            var get = controller.GetAttendees();
            Assert.IsTrue(!get.Contains(response));
            //response.WillAttend = true;
            //controller.HebeleHubele(response);
            //get = controller.GetAttendees();
            //Assert.IsTrue(get.Contains(response));

        }
    }
}
