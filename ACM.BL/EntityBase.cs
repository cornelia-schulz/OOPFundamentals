using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    // this is a base class
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool isNew { get; set; }
        public bool isValid => Validate();

        // if method is abstract (i.e. has no implementation) the class needs to be made abstract/incomplete as well
        public abstract bool Validate();
    }
}
