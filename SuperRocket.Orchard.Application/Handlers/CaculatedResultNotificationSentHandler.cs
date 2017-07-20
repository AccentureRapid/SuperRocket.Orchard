using Abp.BackgroundJobs;
using Abp.Dependency;
using Abp.Events.Bus.Handlers;
using SuperRocket.Orchard.Events;
using SuperRocket.Orchard.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRocket.Orchard.Handlers
{
    public class CaculatedResultNotificationSentHandler : IEventHandler<CaculatedResultNotificationSentEventData>, ITransientDependency
    {
        private readonly IBackgroundJobManager _backgroundJobManager;

        public CaculatedResultNotificationSentHandler(IBackgroundJobManager backgroundJobManager)
        {
            _backgroundJobManager = backgroundJobManager;
        }

        public void HandleEvent(CaculatedResultNotificationSentEventData eventData)
        {
            Console.WriteLine(string.Format("CaculatedResult completed and sent email {0} successfully!", eventData.Subject));
            Console.WriteLine(string.Format("all jobs completed !"));
        }
    }
}
