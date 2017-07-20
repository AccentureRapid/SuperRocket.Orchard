using Abp.BackgroundJobs;
using Abp.Dependency;
using Abp.Events.Bus;
using SuperRocket.Orchard.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperRocket.Orchard.Job
{
    public class CaculatedResultNotificationJob : BackgroundJob<CaculatedResultNotificationSentEventData>, ITransientDependency
    {
        private IEventBus _eventBus;

        public CaculatedResultNotificationJob(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public override void Execute(CaculatedResultNotificationSentEventData data)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Caculated completed and send ResultNotification Email {0} successfully!", data.Subject);
            _eventBus.Trigger(new CaculatedResultNotificationSentEventData {  Subject = data.Subject });
        }
    }
}
