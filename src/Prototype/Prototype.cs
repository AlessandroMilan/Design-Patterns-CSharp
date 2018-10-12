using System;

namespace Prototype
{
    public abstract class IPrototype
    {    
        private string _id;

        // Constructor
        public IPrototype(string id)
        {
            this._id = id;
        }

        // Gets id
        public string Id
        {
            get { return _id; }
        }

        public abstract IPrototype Clone();
    }
}
