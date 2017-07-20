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
    public class EmailSentEventHandler : IEventHandler<EmailSentEventData>, ITransientDependency
    {
        private readonly IBackgroundJobManager _backgroundJobManager;

        public EmailSentEventHandler(IBackgroundJobManager backgroundJobManager)
        {
            _backgroundJobManager = backgroundJobManager;
        }

        public void HandleEvent(EmailSentEventData eventData)
        {
            Console.WriteLine(string.Format("Email job completed, then start next job!", DateTime.Now.ToString(), eventData.Subject));
            _backgroundJobManager.Enqueue<CaculateLaborRateJob, CaculatedResultNotificationSentEventData>( new CaculatedResultNotificationSentEventData { Subject = "please send CaculatedResult completed email to these people." });
        }
    }
}
