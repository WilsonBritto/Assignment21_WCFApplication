using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment21_WCF_Service_Q1_Task2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQ1T2" in both code and config file together.
    [ServiceContract]
    public interface IQ1T2
    {
        [OperationContract]
        List<Openings> OpeningsJobs();
        [OperationContract]
        List<Openings> OpeningJobsByRole(RoleType Role);
    }
    [DataContract]
    public class Openings
    {
        [DataMember]
        public string Job { get; set; }
        [DataMember]
        public RoleType Role { get; set; }
        
    }
    [DataContract]
    public enum RoleType
    {
        [EnumMember]
        Trainee,
        [EnumMember]
        Analyst,
        [EnumMember]
        SeniorAnalyst,
        [EnumMember]
        Lead
    }
}
