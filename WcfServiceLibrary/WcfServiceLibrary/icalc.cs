using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfServiceLibrary
{
    [ServiceContract]
    interface icalc
    {
        [WebInvoke (Method ="PUT" , UriTemplate ="addname")]
        [OperationContract]
        List<string> add(string name);
        [WebInvoke(Method = "GET", UriTemplate = "getall")]
        [OperationContract]
        List<string> getall();
        [WebInvoke(Method = "GET", UriTemplate = "getbyindex/{index}")]
        [OperationContract]
        string getbyindex(string index);
    }
}
