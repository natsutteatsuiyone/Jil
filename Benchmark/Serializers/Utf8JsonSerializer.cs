using System.IO;

namespace Benchmark.Serializers
{
    public class Utf8JsonSerializer_Utf8Bytes : SerializerBase
    {
        public override object Serialize<T>(T input)
        {
            return Utf8Json.JsonSerializer.Serialize(input);
        }

        public override T Deserialize<T>(object input)
        {
            return Utf8Json.JsonSerializer.Deserialize<T>((byte[])input);
        }
    }


    public class Utf8JsonSerializer_String : SerializerBase
    {
        public override object Serialize<T>(T input)
        {
            return Utf8Json.JsonSerializer.ToJsonString(input);
        }

        public override T Deserialize<T>(object input)
        {
            return Utf8Json.JsonSerializer.Deserialize<T>((string)input);
        }
    }

    public class Utf8JsonSerializer_Utf8Stream : SerializerBase
    {
        public override object Serialize<T>(T input)
        {
            var ms = new WrappedMemoryStream();
            Utf8Json.JsonSerializer.Serialize(ms, input);
            ms.Flush();
            return ms;
        }

        public override T Deserialize<T>(object input)
        {
            var ms = input as Stream;
            ms.Position = 0;
            return Utf8Json.JsonSerializer.Deserialize<T>(ms);
        }
    }

    // wrapped for avoid Utf8Json's deserialize by MemoryStream optimization.
    public class WrappedMemoryStream : Stream
    {
        MemoryStream ms;

        public WrappedMemoryStream()
        {
            this.ms = new MemoryStream();
        }

        public override bool CanRead => ms.CanRead;

        public override bool CanSeek => ms.CanSeek;

        public override bool CanWrite => ms.CanWrite;

        public override long Length => ms.Length;

        public override long Position { get => ms.Position; set => ms.Position = value; }

        public override void Flush()
        {
            ms.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return ms.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return ms.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            ms.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            ms.Write(buffer, offset, count);
        }

        public override int ReadByte()
        {
            return ms.ReadByte();
        }


        public override void WriteByte(byte value)
        {
            ms.WriteByte(value);
        }

        public override void Close()
        {
            ms.Close();
        }

        public override bool CanTimeout => ms.CanTimeout;

        public override int ReadTimeout { get => int.MaxValue; set => ms.ReadTimeout = value; }

        public override int WriteTimeout { get => int.MaxValue; set => ms.WriteTimeout = value; }
    }
}