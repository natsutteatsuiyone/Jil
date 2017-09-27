namespace Benchmark.Serializers
{
    public class Utf8JsonSerializer : SerializerBase
    {
        public override string Serialize<T>(T input)
        {
            return Utf8Json.JsonSerializer.ToJsonString(input);
        }

        public override T Deserialize<T>(string input)
        {
            return Utf8Json.JsonSerializer.Deserialize<T>(input);
        }
    }
}