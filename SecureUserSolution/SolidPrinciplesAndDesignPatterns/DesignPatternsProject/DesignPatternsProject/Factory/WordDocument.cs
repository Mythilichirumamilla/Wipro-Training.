using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Factory
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Word Document opened");
        }
    }
}

