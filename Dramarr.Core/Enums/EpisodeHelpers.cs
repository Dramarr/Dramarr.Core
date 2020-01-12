using System;

namespace Dramarr.Core.Enums
{
    public class EpisodeHelpers
    {
        /// <summary>
        /// Episode status enum
        /// </summary>
        public enum EpisodeStatus
        {
            UNKNOWN,
            SCRAPED,
            NOT_DOWNLOADED,
            DOWNLOADED,
            FAILED,
        }
    }
}
