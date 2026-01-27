using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesProject.SRP
{
    // Responsible ONLY for generating reports
    public class ReportGenerator
    {
        public string GenerateReport()
        {
            return "This is the report content";
        }
    }
}
