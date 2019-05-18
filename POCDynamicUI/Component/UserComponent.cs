using log4net;
using POCDynamicUI.Models;
using System;

namespace POCDynamicUI.Component
{
    public class UserComponent:IUserComponent
    {
        ILog log = log4net.LogManager.GetLogger(typeof(UserComponent));

        /// <summary>
        /// Saving User Details.
        /// </summary>
        /// <param name="userDetails"></param>
        /// <returns></returns>
        
        public void SaveUserDetails(UserDetails userDetails) 
        {
            try
            {
                // add some logic
                log.Info("### Inside Save User Details: " + userDetails.ToString());
            }
            catch (Exception)
            {
                throw new Exception("Some error occurred !!");
            }
        }
    }
}