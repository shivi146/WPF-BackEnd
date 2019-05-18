using log4net;
using POCDynamicUI.Component;
using POCDynamicUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POCDynamicUI.Controllers
{
    public class UserController : ApiController,IUserController
    {
        ILog log = log4net.LogManager.GetLogger(typeof(UserController));
        private readonly IUserComponent userComponent;
        public UserController(IUserComponent _userComponent)
        {
            this.userComponent = _userComponent;
        }
        /// <summary>
        /// Calling Save User Details method of UserComponent.
        /// </summary>
        /// <param name="userDetails"></param>
        /// <returns></returns>

        [HttpPost]
        public HttpResponseMessage SaveUserDetails(UserDetails userDetails)
        {
            try
            {
                log.Info("### Inside Save User Details ");
                userComponent.SaveUserDetails(userDetails);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError,"Some error occurred !!");
            }
           
        }
    }
}
