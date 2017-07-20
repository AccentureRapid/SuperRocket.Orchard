using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRocket.Orchard.Events
{
    public class LoadInterfaceDataLoadedEventsData : EventData
    {
        public string FileName { get; set; }
    }

    public class EmailSentEventData : EventData
    {
        public string Subject { get; set; }
    }

    public class LaborRateCaculatedEventData : EventData
    {
        public string Rate { get; set; }
    }

    public class CaculatedResultNotificationSentEventData : EventData
    {
        public string Subject { get; set; }
    }
}
