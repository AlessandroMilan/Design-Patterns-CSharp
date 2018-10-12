using System;

namespace Prototype.Concrete 
{
    public class ConcretePrototypeTwo : IPrototype
    {
        public ConcretePrototypeTwo() : base("Two")
        {
        }
         
        // Returns a shallow copy
        public override IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }
}
