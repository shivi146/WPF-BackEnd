﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace POCDynamicUI
{
    public interface IFormDetailsController
    {
        HttpResponseMessage GetFormData(string FormId);
    }
}