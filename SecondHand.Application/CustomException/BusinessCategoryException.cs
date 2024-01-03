using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SecondHand.Application.CustomException
{
    [Serializable]
    internal class BusinessCategoryAlreadyExistsException : Exception
    {
        public BusinessCategoryAlreadyExistsException()
        {
        }

        public BusinessCategoryAlreadyExistsException(string? message) : base(message)
        {
        }

        public BusinessCategoryAlreadyExistsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BusinessCategoryAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}