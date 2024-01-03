using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.CustomException
{
    public class GoogleMapsApiException : Exception
    {
        public GoogleMapsApiException()
        {
        }

        public GoogleMapsApiException(string? message) : base(message)
        {
        }

        public GoogleMapsApiException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}