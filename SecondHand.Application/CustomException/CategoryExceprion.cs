using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SecondHand.Application.CustomException
{
    [Serializable]
    internal class CategoryNotFoundException : Exception
    {
        public CategoryNotFoundException()
        {
        }

        public CategoryNotFoundException(string? message) : base(message)
        {
        }

        public CategoryNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CategoryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}