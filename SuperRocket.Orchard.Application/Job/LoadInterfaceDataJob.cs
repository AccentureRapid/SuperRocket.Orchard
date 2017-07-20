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
    public class LoadInterfaceDataJob : BackgroundJob<LoadInterfaceDataLoadedEventsData>, ITransientDependency
    {
        private IEventBus _eventBus;

        public LoadInterfaceDataJob(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public override void Execute(LoadInterfaceDataLoadedEventsData data)
        {
            Thread.Sleep(5000);
            Console.WriteLine("{0} Interface data  {1} loaded successfully!", DateTime.Now.ToString(), data.FileName);
            _eventBus.Trigger(new LoadInterfaceDataLoadedEventsData { FileName = string.Format("{0}.data", DateTime.Now.ToString()) });
        }
    }
}
