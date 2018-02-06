using FactoryMethod.Creator;
using FactoryMethod.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryMethodTest
{
    [TestClass]
    public class GifReaderCreatorTest
    {
        [TestMethod]
        public void ImageReaderCreatedMustBeInstanceOfGifReader()
        {
            ImageReaderCreator imageReaderCreator = new ImageReaderCreator();
            ImageReader imageReader = imageReaderCreator.PrepareImageReader("/Home/Design-Patterns-CSharp", ImageReaderCreator.ImageFormat.GIF);

            // Must be a GIF image.
            Assert.AreEqual("/Home/Design-Patterns-CSharp.GIF", imageReader.Source);
        }
    }
}
