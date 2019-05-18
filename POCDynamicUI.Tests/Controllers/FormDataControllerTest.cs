using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using POCDynamicUI.Component;
using POCDynamicUI.Controllers;
using System;
using System.Net.Http;
using System.Web.Http;


namespace POCDynamicUI.Tests.Controllers
{
    [TestClass]
    public class FormDataControllerTest
    {
        /// <summary>
        /// This test case will check whether controller returns status code Ok if everything works fine.
        /// The thing to note is that we have mocked component to return a dummy response.
        /// </summary>
        [TestMethod]
        public void Test_GetFormData_Success()
        {
            var formDataComponentMock = new Mock<IFormDataComponent>();

            //Mocking component layer
            formDataComponentMock.Setup(x => x.GetFormData(It.IsAny<string>())).Returns(Newtonsoft.Json.Linq.JObject.Parse("{'hello':'hello'}"));
            var formDetailsController = new FormDetailsController(formDataComponentMock.Object)
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
            var response = formDetailsController.GetFormData("registrationinfo");
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// This test case will check whether controller sends InternalServerError code if component throws exception.
        /// </summary>
        [TestMethod]
        public void Test_GetFormData_Failure()
        {
            var formDataComponentMock = new Mock<IFormDataComponent>();

            //Mocking component layer to explicitly throw exception
            formDataComponentMock.Setup(x => x.GetFormData(It.IsAny<string>())).Throws<Exception>();
            var formDetailsController = new FormDetailsController(formDataComponentMock.Object)
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            var response = formDetailsController.GetFormData("registrationinfo");
            Assert.AreEqual(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }
    }
}
