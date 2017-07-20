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
    public class InterfaceDataLoadedEventHandler : IEventHandler<LoadInterfaceDataLoadedEventsData>, ITransientDependency
    {
        private readonly IBackgroundJobManager _backgroundJobManager;

        public InterfaceDataLoadedEventHandler(IBackgroundJobManager backgroundJobManager)
        {
            _backgroundJobManager = backgroundJobManager;
        }

        public void HandleEvent(LoadInterfaceDataLoadedEventsData eventData)
        {
            Console.WriteLine(string.Format("{0} Interface data  {1} loaded completed, then start next job!", DateTime.Now.ToString(), eventData.FileName));
            _backgroundJobManager.Enqueue<SendInterfaceLoadedEmailJob, EmailSentEventData>( new EmailSentEventData { Subject = "please send email to these people." });
        }
    }
}
