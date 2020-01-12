using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dramarr.Core.Tests
{
    [TestClass]
    public class TaskTests
    {
        public bool Function()
        {
            return true;
        }

        [TestMethod]
        public void ShouldRetry()
        {
            var timeout = TimeSpan.FromSeconds(5);
            Retry.RetryHelpers.Do(Function, timeout);
        }

    }
}
