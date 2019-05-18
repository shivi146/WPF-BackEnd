using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using POCDynamicUI.Component;
using System;

namespace POCDynamicUI.Tests.Component
{
    [TestClass]
    public class FormDataComponentTest
    {
        /// <summary>
        /// This test case compares the form data structure.
        /// </summary>
        [TestMethod]
        public void Test_GetFormDataComponent_Success()
        {
            string strInput = @"{
  'TextBoxes': [
    {
      'Label': 'First name',
      'Enabled': true
    },
    {
      'Label': 'Last name',
      'Enabled': true
    },
    {
      'Label': 'Age',
      'Enabled': false
    }
   ]
}";
            FormDataComponent formDataComponent = new FormDataComponent();
            JObject response = formDataComponent.GetFormData("registrationinfo");
            Assert.AreEqual(JObject.Parse(strInput).ToString(), response.ToString());
        }

        /// <summary>
        /// This test case will throw exception if there is some error in the file name,file not found,mismatching of form data
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_GetFormDataComponent_Failure()
        {
            FormDataComponent formDataComponent = new FormDataComponent();
            //Wrong Form Id being passed.
            formDataComponent.GetFormData("testregistrationinfo");
        }
    }
}
