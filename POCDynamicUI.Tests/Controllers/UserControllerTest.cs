using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using POCDynamicUI.Component;
using POCDynamicUI.Controllers;
using POCDynamicUI.Models;
using System;
using System.Net.Http;
using System.Web.Http;

namespace POCDynamicUI.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        /// <summary>
        /// This test case will check whether controller returns status code Ok if everything works fine.
        /// The thing to note is that we have mocked component to return a dummy response.
        /// </summary>

        [TestMethod]
        public void Test_SaveUserDetails_Success()
        {
            var userComponentMock = new Mock<IUserComponent>();
            UserDetails userDetails = new UserDetails();
            //Mocking component layer
            userComponentMock.Setup(x => x.SaveUserDetails(userDetails));
            var usercontroller = new UserController(userComponentMock.Object)
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            var response = usercontroller.SaveUserDetails(userDetails);
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
        }

        /// <summary>
        /// This test case will check whether controller sends InternalServerError code if component throws exception.
        /// </summary>

        [TestMethod]
        public void Test_SaveUserDetails_Failure()
        {
            var userComponentMock = new Mock<IUserComponent>();
            UserDetails userDetails = new UserDetails();
            //Mocking component layer
            userComponentMock.Setup(x => x.SaveUserDetails(userDetails)).Throws<Exception>();
            var usercontroller = new UserController(userComponentMock.Object)
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
            var response = usercontroller.SaveUserDetails(userDetails);
            Assert.AreEqual(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }
    }
}
