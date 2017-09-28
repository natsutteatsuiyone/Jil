using System;
using Jil;

namespace Benchmark.Serializers
{
    public class JilSerializer : SerializerBase
    {
        public override T Deserialize<T>(object input)
        {
            return Jil.JSON.Deserialize<T>((string) input, Options.ISO8601);
        }

        public override object Serialize<T>(T input)
        {
            return Jil.JSON.Serialize(input, Options.ISO8601);
        }
    }
}