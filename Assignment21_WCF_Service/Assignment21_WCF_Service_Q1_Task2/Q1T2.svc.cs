using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment21_WCF_Service_Q1_Task2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Q1T2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Q1T2.svc or Q1T2.svc.cs at the Solution Explorer and start debugging.
    public class Q1T2 : IQ1T2
    {
        List<Openings> OpeningsList = null;
        public Q1T2()
        {
            OpeningsList = new List<Openings>()
            {
                new Openings
                {
                    Job = "Job1",
                    Role = RoleType.Analyst
                },
                new Openings
                {
                    Job = "Job2",
                    Role = RoleType.Lead
                },
                new Openings
                {
                    Job = "Job3",
                    Role = RoleType.Analyst
                },
                new Openings
                {
                    Job = "Job4",
                    Role = RoleType.SeniorAnalyst
                },
                new Openings
                {
                    Job = "Job5",
                    Role = RoleType.Trainee
                },
                new Openings
                {
                    Job = "Job6",
                    Role = RoleType.SeniorAnalyst
                },
                new Openings
                {
                    Job = "Job7",
                    Role = RoleType.SeniorAnalyst
                }
            };
        }
        public List<Openings> OpeningJobsByRole(RoleType Role)
        {
            return OpeningsList.Where(x => x.Role == Role).ToList();
        }

        public List<Openings> OpeningsJobs()
        {
            return OpeningsList;
        }
        
    }
}
