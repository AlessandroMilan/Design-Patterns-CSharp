using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class GifReaderCreator : ImageReaderCreator
    {
        protected override ImageReader CreateImageReader()
        {
            ImageReader imageReader;

            imageReader = new GifReader();
            return imageReader;
        }
    }
}
