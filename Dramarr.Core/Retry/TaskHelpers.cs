using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dramarr.Core.Retry
{
    public class TaskHelpers
    {
        /// <summary>
        /// Runs a task and waits for the timeout to run again, in case it fails it tries again after the timeout
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="timeout"></param>
        public static void Retry<T>(Func<T> func, TimeSpan timeout)
        {
            while (true)
            {
                try
                {
                    func();
                    Thread.Sleep(timeout);
                }
                catch (Exception)
                {
                    Thread.Sleep(timeout);
                }
            }
        }
    }
}
