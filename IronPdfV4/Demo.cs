using System.IO;
using IronPdf;

namespace IronPdfV4
{
    public class Demo
    {
        public int TryAccessProperties(FileInfo pdf)
        {
            var pdfDocument = PdfDocument.FromFile(pdf.FullName);
            return pdfDocument.PageCount;
        }
    }
}