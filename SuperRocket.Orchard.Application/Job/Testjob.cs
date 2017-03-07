using Abp.BackgroundJobs;
using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRocket.Orchard.Job
{
    public class TestJob : BackgroundJob<int>, ITransientDependency
    {
        public override void Execute(int number)
        {
            Console.WriteLine("{0} Test job completed with {1} counts successfully!", DateTime.Now.ToString(), number);
        }
    }
}
