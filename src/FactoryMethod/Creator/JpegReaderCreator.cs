using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class JpegReaderCreator : ImageReaderCreator
    {
        protected override ImageReader CreateImageReader()
        {
            ImageReader imageReader = new JpegReader();

            return imageReader;
        }
    }
}
