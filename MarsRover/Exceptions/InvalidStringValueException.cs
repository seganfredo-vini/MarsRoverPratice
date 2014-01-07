using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public class InvalidStringValueException: System.Exception
    {
        public InvalidStringValueException() : base() { }
        public InvalidStringValueException(string message) : base(message) { }
        public InvalidStringValueException(string message, System.Exception inner) : base(message, inner) { }

        //protected InvalidStringValueException(System.Runtime.Serialization.SerializationInfo info,
        //System.Runtime.Serialization.StreamingContext context) { }
    }
}
