using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text;

namespace POCDynamicUI.Component
{
    public class FormDataComponent:IFormDataComponent
    {
        ILog log = log4net.LogManager.GetLogger(typeof(FormDataComponent));
        readonly string jsonFilePath = Config.FilePath;

        StringBuilder formID = new StringBuilder();
        StringBuilder fileContentAsText = new StringBuilder();

        /// <summary>
        /// Getting the sttructure of the Form.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public JObject GetFormData(string formId)
        {
            try
            {               
                formID.Append(Constants.formKeyword).Append(Constants.pathSeparaotor).Append(formId).Append(Constants.extensionFile);              
                fileContentAsText.Append(jsonFilePath).Append(formID);                
                return JObject.Parse(File.ReadAllText(fileContentAsText.ToString()));
            }
            catch (Exception ex)
            {
                log.Error("Error while fetching the Form Structure!! "+ ex.Message);
                throw new Exception("Some error occurred!!");
            }                     
        }
    }
}