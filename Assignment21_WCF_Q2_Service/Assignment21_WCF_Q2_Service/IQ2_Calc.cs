using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment21_WCF_Q2_Service
{
    [ServiceContract]
    public interface IQ2_Calc
    {
        [OperationContract]
        int Add2Num(int a, int b);
        [OperationContract]
        int Sub2Num(int a, int b);
    }

}
