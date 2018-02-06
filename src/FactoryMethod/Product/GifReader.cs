namespace FactoryMethod.Product
{
    class GifReader : ImageReader
    {
        public GifReader()
        {
            Format = "GIF";
        }

        public override void SetImageSource(string imageSource)
        {
            Source = string.Format("{0}.{1}",imageSource, Format);
        }
    }
}
