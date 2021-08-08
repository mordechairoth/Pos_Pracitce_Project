using System;


namespace POS
{
    [System.AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    internal sealed class NotMappedWriteAttribute : Attribute
    {
       
    }
}
