using System;

namespace Benchmark.Fixture
{
    public class DateTimeValueFixture : IValueFixture
    {
        private long _lastValue;
        public Type Type { get; } = typeof(DateTime);

        public object Generate()
        {
            _lastValue += 1000;
            return DateTime.FromBinary(_lastValue);
        }
    }
}