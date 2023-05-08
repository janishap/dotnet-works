using System;
using System.Runtime.Serialization;

namespace bankexeception
{
    [Serializable]
    internal class bankException : Exception
    {
        public bankException()
        {
        }

        public bankException(string message) : base(message)
        {
        }

        public bankException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected bankException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}