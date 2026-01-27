using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Factory
{
    public class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            if (type == "PDF")
                return new PdfDocument();
            else if (type == "WORD")
                return new WordDocument();
            else
                throw new ArgumentException("Invalid document type");
        }
    }
}
