using System;
using System.Threading;
using System.Threading.Tasks;
using Abstractions.EventConsumer.Exceptions;
using Abstractions.Events.Models;

namespace Abstractions.EventConsumer
{
    /// <summary>
    /// Contract for the service responsible for the consumption of a event from an event store asynchronously
    /// </summary>
    public interface IConsumerAsync : IDisposable
    {
        /// <summary>
        /// Consumes an event from the event store from a specific topic asynchronously
        /// </summary>
        /// <param name="topic">the topic to consume from</param>
        /// <param name="token">the cancellation token</param>
        /// <exception cref="ConsumerException">if any consuming operation fails</exception>
        /// <returns>the task with the consumed event</returns>
        Task<Event> ConsumeAsync(string topic, CancellationToken token = default);
    }
}