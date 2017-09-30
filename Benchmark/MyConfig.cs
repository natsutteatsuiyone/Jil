using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Horology;
using BenchmarkDotNet.Jobs;

namespace Benchmark
{
    public class MyConfig : ManualConfig
    {
        public MyConfig()
        {
            // Add(Job.Default);

            // run quickly:)
            var baseConfig = Job.ShortRun.WithLaunchCount(1).WithTargetCount(1).WithWarmupCount(1);
            Add(baseConfig.With(Runtime.Clr).With(Jit.RyuJit).With(Platform.X64));

            Add(CsvMeasurementsExporter.Default);
            Add(MarkdownExporter.GitHub);
            Add(MemoryDiagnoser.Default);
        }
    }
}
