using System;
using Jil;

namespace Benchmark.Serializers
{
    public class JilSerializer : SerializerBase
    {
        public override object Serialize(object input)
        {
            return JSON.Serialize(input, Options.ISO8601ExcludeNullsIncludeInherited);
        }

        public override object Deserialize(object input, Type type)
        {
            return JSON.Deserialize((string) input, type, Options.ISO8601ExcludeNullsIncludeInherited);
        }
    }
}