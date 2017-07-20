using Abp.BackgroundJobs;
using SuperRocket.Orchard.Events;
using SuperRocket.Orchard.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRocket.Orchard.Services
{
    public class TestService : ITestService
    {
        private readonly IBackgroundJobManager _backgroundJobManager;

        public TestService(IBackgroundJobManager backgroundJobManager)
        {
            _backgroundJobManager = backgroundJobManager;
        }

        public void Test()
        {
            //_backgroundJobManager.Enqueue<TestJob, int>(1);
            _backgroundJobManager.Enqueue<LoadInterfaceDataJob, LoadInterfaceDataLoadedEventsData>(new LoadInterfaceDataLoadedEventsData { FileName = "This is a test interface file." });
        }
    }
}
