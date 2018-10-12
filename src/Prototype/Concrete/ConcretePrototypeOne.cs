using System;

namespace Prototype.Concrete 
{
    public class ConcretePrototypeOne : IPrototype
    {
        public ConcretePrototypeOne() : base("One")
        {
        }
         
        // Returns a shallow copy
        public override IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }
}
