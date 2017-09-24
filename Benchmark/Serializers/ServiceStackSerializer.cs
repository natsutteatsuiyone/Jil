using System;
using ServiceStack.Text;

namespace Benchmark.Serializers
{
    public class ServiceStackSerializer : SerializerBase
    {
        public override object Serialize(object input)
        {
            return JsonSerializer.SerializeToString(input);
        }

        public override object Deserialize(object input, Type type)
        {
            return JsonSerializer.DeserializeFromString((string) input, type);
        }
    }
}