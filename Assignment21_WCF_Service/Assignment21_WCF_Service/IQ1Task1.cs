using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment21_WCF_Service
{
    [ServiceContract]
    public interface IQ1Task1
    {
        [OperationContract]
        string SayHello(string name);
        [OperationContract]
        string TodayProgram(string name);
    }

    
}
