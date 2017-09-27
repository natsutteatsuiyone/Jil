using System;
using Jil;

namespace Benchmark.Serializers
{
    public class JilSerializer : SerializerBase
    {
        public override T Deserialize<T>(string input)
        {
            return Jil.JSON.Deserialize<T>(input);
        }

        public override string Serialize<T>(T input)
        {
            return Jil.JSON.Serialize(input);
        }
    }
}