using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Horology;
using BenchmarkDotNet.Jobs;

namespace Benchmark
{
    public class MyConfig : ManualConfig
    {
        public MyConfig()
        {
            Add(
                Job.Dry
                    .With(Platform.X64)
                    .With(Jit.RyuJit)
                    .With(Runtime.Clr)
                    .WithLaunchCount(5)
                    .WithIterationTime(TimeInterval.Millisecond * 200)
                    .WithId("MySuperJob")); // IMPORTANT: Id assignment should be the last call in the chain or the id will be lost.
        }
    }
}
