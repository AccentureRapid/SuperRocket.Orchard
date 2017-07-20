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
    public class LaborRateCaculatedEventHandler : IEventHandler<LaborRateCaculatedEventData>, ITransientDependency
    {
        private readonly IBackgroundJobManager _backgroundJobManager;

        public LaborRateCaculatedEventHandler(IBackgroundJobManager backgroundJobManager)
        {
            _backgroundJobManager = backgroundJobManager;
        }

        public void HandleEvent(LaborRateCaculatedEventData eventData)
        {
            Console.WriteLine(string.Format("Labor Rate Caculated completedly {0} successfully!", eventData.Rate));
            Console.WriteLine(string.Format("all jobs completed !"));
            _backgroundJobManager.Enqueue<CaculatedResultNotificationJob, CaculatedResultNotificationSentEventData>(new CaculatedResultNotificationSentEventData { Subject = "Great~ All is caculated" });
        }
    }
}
