using System;
using Jil;
using System.IO;
using System.Text;

namespace Benchmark.Serializers
{
    public class JilSerializer_Utf8Bytes : SerializerBase
    {
        public override object Serialize<T>(T input)
        {
            return Encoding.UTF8.GetBytes(Jil.JSON.Serialize(input, Options.ISO8601));
        }

        public override T Deserialize<T>(object input)
        {
            return Jil.JSON.Deserialize<T>(Encoding.UTF8.GetString((byte[])input), Options.ISO8601);
        }
    }

    public class JilSerializer_String : SerializerBase
    {
        public override T Deserialize<T>(object input)
        {
            return Jil.JSON.Deserialize<T>((string)input, Options.ISO8601);
        }

        public override object Serialize<T>(T input)
        {
            return Jil.JSON.Serialize(input, Options.ISO8601);
        }
    }

    public class JilSerializer_Utf8Stream : SerializerBase
    {
        public override T Deserialize<T>(object input)
        {
            var ms = (Stream)input;
            ms.Position = 0;
            var sr = new StreamReader(ms);
            return Jil.JSON.Deserialize<T>(sr, Options.ISO8601);
        }

        public override object Serialize<T>(T input)
        {
            var ms = new WrappedMemoryStream();
            var sw = new StreamWriter(ms);
            Jil.JSON.Serialize(input, sw, Options.ISO8601);
            sw.Flush();
            ms.Flush();
            return ms;
        }
    }
}