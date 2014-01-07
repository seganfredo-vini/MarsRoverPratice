using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    [Serializable()]
    public class OutOfBoundsException : System.Exception
    {
        public OutOfBoundsException() : base() { }
        public OutOfBoundsException(string message) : base(message) { }
        public OutOfBoundsException(string message, System.Exception inner) : base(message, inner) { }

        //protected OutOfBoundsException(System.Runtime.Serialization.SerializationInfo info,
        //System.Runtime.Serialization.StreamingContext context) { }
    }

}
