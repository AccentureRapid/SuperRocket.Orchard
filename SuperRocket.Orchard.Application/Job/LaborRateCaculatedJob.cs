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
    public class LaborRateCaculatedJob : BackgroundJob<LaborRateCaculatedEventData>, ITransientDependency
    {
        private IEventBus _eventBus;

        public LaborRateCaculatedJob(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public override void Execute(LaborRateCaculatedEventData data)
        {
            Thread.Sleep(5000);

            Console.WriteLine(" Labor Rate {0} Caculation completed successfully!", data.Rate);
            _eventBus.Trigger(new LaborRateCaculatedEventData {  Rate = data.Rate });
        }
    }
}
