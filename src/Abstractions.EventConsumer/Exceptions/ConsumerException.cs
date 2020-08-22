using System;

namespace Abstractions.EventConsumer.Exceptions
{
    public class ConsumerException : ApplicationException
    {
        public ConsumerException(string? message) : base(message) {}
        public ConsumerException(string? message, Exception? innerException) : base(message, innerException) {}
    }
}