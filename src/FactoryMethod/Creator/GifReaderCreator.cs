using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class GifReaderCreator : ImageReaderCreator
    {
        protected override ImageReader CreateImageReader()
        {
            ImageReader imageReader = new GifReader();

            return imageReader;
        }
    }
}
