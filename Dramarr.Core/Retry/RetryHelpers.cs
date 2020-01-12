using System;
using System.Collections.Generic;
using System.Threading;

namespace Dramarr.Core.Retry
{
    public class RetryHelpers
    {
        /// <summary>
        /// Runs a task and waits for the timeout to run again
        /// </summary>
        /// <param name="action"></param>
        /// <param name="retryInterval"></param>
        /// <param name="maxAttemptCount"></param>
        public static void Do(Action action, TimeSpan retryInterval, int maxAttemptCount = 3)
        {
            Do<object>(() =>
            {
                action();
                return null;
            }, retryInterval, maxAttemptCount);
        }

        /// <summary>
        /// Runs a task and waits for the timeout to run again
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <param name="retryInterval"></param>
        /// <param name="maxAttemptCount"></param>
        /// <returns></returns>
        public static T Do<T>(Func<T> action, TimeSpan retryInterval, int maxAttemptCount = 3)
        {
            var exceptions = new List<Exception>();

            for (int attempted = 0; attempted < maxAttemptCount; attempted++)
            {
                try
                {
                    if (attempted > 0)
                    {
                        Thread.Sleep(retryInterval);
                    }
                    return action();
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }
            throw new AggregateException(exceptions);
        }
    }
}
