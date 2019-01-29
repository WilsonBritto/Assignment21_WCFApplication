using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment21_WCF_Q2_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Q2_Calc1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Q2_Calc1.svc or Q2_Calc1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior]
    public class Q2_Calc : IQ2_Calc
    {
        [OperationBehavior]
        public int Add2Num(int a, int b)
        {
            return a + b;
        }
        [OperationBehavior]
        public int Sub2Num(int a, int b)
        {
            return a - b;
        }
    }
}
