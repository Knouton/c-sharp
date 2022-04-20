using System;

namespace CompareObjects2.Exceptions
{
    public class ObjectTypeException : Exception
    {
        public ObjectTypeException(string objectType1, string objectType2) : base($"Object1 type: \"{objectType1}\"; Object2 type: {objectType2}") { }
    }
}
