using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesProject.DIP
{
    public class ReportService
    {
        private readonly IReportGenerator _generator;

        public ReportService(IReportGenerator generator)
        {
            _generator = generator;
        }

        public void ProcessReport()
        {
            Console.WriteLine(_generator.Generate());
        }
    }
}
