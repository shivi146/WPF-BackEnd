using POCDynamicUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace POCDynamicUI.Controllers
{
    public interface IUserController
    {
        HttpResponseMessage SaveUserDetails(UserDetails userDetails);
    }
}