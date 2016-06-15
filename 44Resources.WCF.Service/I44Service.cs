using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _44Resources.WCF.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "I44Service" in both code and config file together.
    [ServiceContract]
    public interface I44Service
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/DoWork/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string DoWork();
    }
}
