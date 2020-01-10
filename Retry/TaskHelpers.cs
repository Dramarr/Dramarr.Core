using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dramarr.Core.Retry
{
    public class TaskHelpers
    {
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
