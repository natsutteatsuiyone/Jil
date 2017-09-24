using System;

namespace Benchmark.Serializers
{
    public abstract class SerializerBase
    {
        public abstract object Serialize(object input);

        public abstract object Deserialize(object input, Type type);
    }
}