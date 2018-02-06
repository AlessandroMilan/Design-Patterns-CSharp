namespace FactoryMethod.Product
{
    class JpegReader : ImageReader
    {
        public JpegReader()
        {
            Format = "JPEG";
        }

        public override void SetImageSource(string imageSource)
        {
            Source = string.Format("{0}.{1}", imageSource, Format);
        }
    }
}
