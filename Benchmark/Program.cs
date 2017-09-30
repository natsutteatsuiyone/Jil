using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using Benchmark.Serializers;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    public class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkDotNet.Running.BenchmarkRunner.Run<ModelBenchmark_Utf8Bytes>();
            BenchmarkDotNet.Running.BenchmarkRunner.Run<ModelBenchmark_Utf8Stream>();
            BenchmarkDotNet.Running.BenchmarkRunner.Run<ModelBenchmark_String>();
        }
    }
}