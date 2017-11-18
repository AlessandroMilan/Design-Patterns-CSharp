using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Creator
{
    public abstract class ImageReaderCreator
    {
        public ImageReader PrepareImageReader(string source)
        {
            ImageReader imageReader = CreateImageReader();

            imageReader.SetImageSource(source);
            return imageReader;
        }

        protected abstract ImageReader CreateImageReader();
    }
}
