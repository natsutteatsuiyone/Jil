using System;
using Jil;

namespace Benchmark.Serializers
{
    public class JilSerializer : SerializerBase
    {
        public override T Deserialize<T>(string input)
        {
            return Jil.JSON.Deserialize<T>(input, Options.ISO8601);
        }

        public override string Serialize<T>(T input)
        {
            return Jil.JSON.Serialize(input, Options.ISO8601);
        }
    }
}