using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POCDynamicUI.Component;
using POCDynamicUI.Models;

namespace POCDynamicUI.Tests.Component
{
    [TestClass]
    public class UserComponentTest
    {
        /// <summary>
        /// This test case checks if the component saves the form data structure.
        /// </summary>
        [TestMethod]
        public void Test_SaveUserDetails_Success()
        {           
            UserComponent userComponent = new UserComponent();
            UserDetails userDetails = new UserDetails()
            {
                FirstName = "Shivangi",
                LastName = "Garg",
                Age = 25
            };
            userComponent.SaveUserDetails(userDetails);         
        }

        /// <summary>
        /// This test case will throw exception if there is some error while saving the data.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_SaveUserDetails_Failure()
        {
            UserComponent userComponent = new UserComponent();
            //Empty userDetails being passed.            
            userComponent.SaveUserDetails(null);
        }
    }
}
