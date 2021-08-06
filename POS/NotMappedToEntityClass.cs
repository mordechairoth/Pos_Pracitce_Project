using System;
using System.Collections.Generic;
using System.Text;

namespace POS
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    sealed class NotMappedToEntityClassAttribute : Attribute
    {
        public NotMappedToEntityClassAttribute()
        {

        }
    }
}
