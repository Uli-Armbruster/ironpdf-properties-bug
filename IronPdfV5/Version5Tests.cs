using System;
using System.IO;
using Xunit;

namespace IronPdfV5
{
    public class Version5Tests
    {
        [Fact]
        public void Accessing_property_of_write_protected_pdf_fails()
        {
            var sut = new Demo();
            var fileInfo = new FileInfo("write-protected.pdf");

            Action act = () => sut.TryAccessProperties(fileInfo);
            var ex = Assert.Throws<NullReferenceException>(act);

            Assert.NotNull(ex);
        }

        [Fact]
        public void Accessing_property_of_writeable_pdfs_succeeds()
        {
            var sut = new Demo();
            var fileInfo = new FileInfo("default.pdf");

            Action act = () => sut.TryAccessProperties(fileInfo);
            var ex = Assert.Throws<NullReferenceException>(act);

            Assert.NotNull(ex);
        }
    }
}