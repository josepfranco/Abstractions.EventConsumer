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
        /// Called whenever an event is consumed from the event store
        /// </summary>
        event Action<Event> ConsumptionHandler;
        
        /// <summary>
        /// Continuously consumes an event from the event store from a specific topic.
        /// This method will be responsible for invoking the <see cref="ConsumptionHandler"/> event.
        /// </summary>
        /// <param name="topic">the topic to consume from</param>
        /// <exception cref="ConsumerException">if any consuming operation fails</exception>
        void Consume(string topic);
    }
}