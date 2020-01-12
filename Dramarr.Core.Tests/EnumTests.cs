using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dramarr.Core.Tests
{
    [TestClass]
    public class EnumTests
    {
        [TestMethod]
        public void ShouldSetEpisode()
        {
            var selctedEnum = Dramarr.Core.Enums.EpisodeHelpers.EpisodeStatus.DOWNLOADED;

            Assert.AreEqual(selctedEnum, Enums.EpisodeHelpers.EpisodeStatus.DOWNLOADED);
            Assert.AreNotEqual(selctedEnum, Enums.EpisodeHelpers.EpisodeStatus.FAILED);
        }

        [TestMethod]
        public void ShouldSetLog()
        {
            var selctedEnum = Dramarr.Core.Enums.LogHelpers.LogType.DEBUG;

            Assert.AreEqual(selctedEnum, Dramarr.Core.Enums.LogHelpers.LogType.DEBUG);
            Assert.AreNotEqual(selctedEnum, Dramarr.Core.Enums.LogHelpers.LogType.WARNING);
        }

        [TestMethod]
        public void ShouldSetSource()
        {
            var selctedEnum = Dramarr.Core.Enums.SourceHelpers.Source.ESTRENOSDORAMAS;

            Assert.AreEqual(selctedEnum, Dramarr.Core.Enums.SourceHelpers.Source.ESTRENOSDORAMAS);
            Assert.AreNotEqual(selctedEnum, Dramarr.Core.Enums.SourceHelpers.Source.MYASIANTV);
        }
    }
}
