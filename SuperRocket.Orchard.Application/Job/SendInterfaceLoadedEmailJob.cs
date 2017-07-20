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
    public class SendInterfaceLoadedEmailJob : BackgroundJob<EmailSentEventData>, ITransientDependency
    {
        private IEventBus _eventBus;

        public SendInterfaceLoadedEmailJob(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public override void Execute(EmailSentEventData data)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Email with {0} sent successfully!", data.Subject);
            _eventBus.Trigger(new EmailSentEventData {  Subject = data.Subject });
        }
    }
}
