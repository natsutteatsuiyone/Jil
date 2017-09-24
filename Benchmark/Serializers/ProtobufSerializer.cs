using System;
using System.IO;
using ProtoBuf;

namespace Benchmark.Serializers
{
    public class ProtobufSerializer : SerializerBase
    {
        public override object Serialize(object input)
        {
            using (var mem = new MemoryStream())
            {
                Serializer.Serialize(mem, input);
                return mem.ToArray();
            }
        }

        public override object Deserialize(object input, Type type)
        {
            using (var mem = new MemoryStream((byte[]) input))
            {
                return Serializer.Deserialize(type, mem);
            }
        }
    }
}