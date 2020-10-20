using System;
using System.Collections.Generic;
using NzbDrone.Core.Datastore;

namespace NzbDrone.Core.History
{
    public class History : ModelBase
    {
        public History()
        {
            Data = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        public int IndexerId { get; set; }
        public string SourceTitle { get; set; }
        public DateTime Date { get; set; }
        public HistoryEventType EventType { get; set; }
        public Dictionary<string, string> Data { get; set; }

        public string DownloadId { get; set; }
    }

    public enum HistoryEventType
    {
        Unknown = 0,
        ReleaseGrabbed = 1
    }
}
