using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class ImageReaderCreator
    {
        public enum ImageFormat
        {
            JPEG,
            GIF
        }

        public ImageReader PrepareImageReader(string source, ImageFormat format)
        {
            ImageReader imageReader = CreateImageReader(format);

            imageReader.SetImageSource(source);
            return imageReader;
        }

        protected ImageReader CreateImageReader(ImageFormat format)
        {
            ImageReader imageReader;

            switch (format)
            {
                case ImageFormat.GIF:
                    imageReader = new GifReader();
                    break;
                case ImageFormat.JPEG:
                default:
                    imageReader = new JpegReader();
                    break;
            }
            return imageReader;
        }
    }
}
