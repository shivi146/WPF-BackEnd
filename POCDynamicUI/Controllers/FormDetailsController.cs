using log4net;
using POCDynamicUI.Component;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POCDynamicUI.Controllers
{
    public class FormDetailsController : ApiController, IFormDetailsController 
    {
        ILog log = log4net.LogManager.GetLogger(typeof(FormDetailsController));      
        private readonly IFormDataComponent formDataComponent;
        
        public FormDetailsController(IFormDataComponent _formDataComponent)
        {
            this.formDataComponent = _formDataComponent;
        }

        /// <summary>
        /// Calling Get Form Data method of FormDataComponent.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>

        [HttpGet]
        public HttpResponseMessage GetFormData(string formId)
        {
            try
            {
                log.Info("### Fetching form data with form id: " + formId);
                return Request.CreateResponse(formDataComponent.GetFormData(formId));
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }                   
        }
    }
}
