using POCDynamicUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCDynamicUI.Component
{
   public interface IUserComponent
    {
        void SaveUserDetails(UserDetails userDetails);
    }
}
