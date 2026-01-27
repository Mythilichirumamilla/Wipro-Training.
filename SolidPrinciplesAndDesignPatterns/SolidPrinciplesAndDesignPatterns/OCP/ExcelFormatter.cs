using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesProject.OCP
{
    public class ExcelFormatter : IReportFormatter
    {
        public void Format(string content)
        {
            Console.WriteLine("Formatting report as Excel");
        }
    }
}
