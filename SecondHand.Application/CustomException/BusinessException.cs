using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SecondHand.Application.CustomException
{
    [Serializable]
    internal class BusinessNotFoundException : Exception
    {
        public BusinessNotFoundException()
        {
        }

        public BusinessNotFoundException(string? message) : base(message)
        {
        }

        public BusinessNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BusinessNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}