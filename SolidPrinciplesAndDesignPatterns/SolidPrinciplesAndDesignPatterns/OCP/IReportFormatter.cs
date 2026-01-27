using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesProject.OCP
{
    public interface IReportFormatter
    {
        void Format(string content);
    }
}

