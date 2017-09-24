using System;
using Newtonsoft.Json;

namespace Benchmark.Serializers
{
    public class NewtonsoftSerializer : SerializerBase
    {
        public override object Serialize(object input)
        {
            return JsonConvert.SerializeObject(input);
        }

        public override object Deserialize(object input, Type type)
        {
            return JsonConvert.DeserializeObject((string) input, type);
        }
    }
}