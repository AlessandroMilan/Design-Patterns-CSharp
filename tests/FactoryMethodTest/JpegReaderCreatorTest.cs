using FactoryMethod.Creator;
using FactoryMethod.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryMethodTest
{
    [TestClass]
    public class JpegReaderCreatorTest
    {
        [TestMethod]
        public void ImageReaderCreatedMustBeInstanceOfJpegReader()
        {
            ImageReaderCreator imageReaderCreator = new JpegReaderCreator();
            ImageReader imageReader = imageReaderCreator.PrepareImageReader("/Home/Design-Patterns-CSharp");

            // Must be a JPEG image.
            Assert.AreEqual("/Home/Design-Patterns-CSharp.JPEG", imageReader.Source);
        }
    }
}
