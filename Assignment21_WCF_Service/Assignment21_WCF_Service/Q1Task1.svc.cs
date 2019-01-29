using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment21_WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Q1Task1 : IQ1Task1
    {
        [OperationBehavior]
        public string SayHello(string name)
        {
            if (DateTime.Now.Hour < 12)
                return "Good Morning! " + name;
            if (DateTime.Now.Hour < 17)
                return "Good Afternoon! " + name;
            return "Good Evening! " + name;
            
        }
        [OperationBehavior]
        public string TodayProgram(string name)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                return "Happy weekend! " + name;
            return "Enjoy Working day! " + name;
        }
    }
}
