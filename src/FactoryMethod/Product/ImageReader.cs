using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product
{
    public abstract class ImageReader
    {
        public string Source { get; protected set; }
        protected string Format { get; set; }
        
        public abstract void SetImageSource(string imageSource);
    }
}
