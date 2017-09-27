using System;

namespace Benchmark.Serializers
{
    public abstract class SerializerBase
    {
        public abstract string Serialize<T>(T input);

        public abstract T Deserialize<T>(string input);
    }
}