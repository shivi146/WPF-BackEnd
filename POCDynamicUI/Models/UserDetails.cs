using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POCDynamicUI.Models
{
    public class UserDetails
    {
        [JsonProperty(PropertyName = "First Name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return String.Format("FirstName: {0}, LastName: {1} , Age: {2} ", FirstName, LastName, Age);
        }
    }


}