using System;
using Abstractions.EventConsumer.Exceptions;
using Abstractions.Events.Models;

namespace Abstractions.EventConsumer
{
    /// <summary>
    /// Contract for the service responsible for the consumption of a event from an event store
    /// </summary>
    public interface IConsumer : IDisposable
    {
        /// <summary>
        /// Consumes an event from the event store from a specific topic
        /// </summary>
        /// <param name="topic">the topic to consume from</param>
        /// <exception cref="ConsumerException">if any consuming operation fails</exception>
        /// <returns>the consumed event</returns>
        Event Consume(string topic);
    }
}