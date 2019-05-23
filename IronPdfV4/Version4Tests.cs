using System;
using System.IO;
using Xunit;

namespace IronPdfV4
{
    public class Version4Tests
    {
        [Fact]
        public void Accessing_property_of_write_protected_pdf_fails()
        {
            var sut = new Demo();
            var fileInfo = new FileInfo("write-protected.pdf");

            Action act = () => sut.TryAccessProperties(fileInfo);
            var ex = Assert.Throws<IOException>(act);

            Assert.NotNull(ex);
        }

        [Fact]
        public void Accessing_property_of_writeable_pdfs_succeeds()
        {
            var sut = new Demo();
            var fileInfo = new FileInfo("default.pdf");

            var actual = sut.TryAccessProperties(fileInfo);

            Assert.Equal(2, actual);
        }
    }
}