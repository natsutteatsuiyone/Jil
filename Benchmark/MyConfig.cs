using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Horology;
using BenchmarkDotNet.Jobs;

namespace Benchmark
{
    public class MyConfig : ManualConfig
    {
        public MyConfig()
        {
            Add(Job.Default);
            Add(new MemoryDiagnoser());
        }
    }
}
