using System.Collections.Generic;
using System.Linq;
using Benchmark.Fixture;
using Benchmark.Serializers;
using BenchmarkDotNet.Attributes;

namespace Benchmark
{        
    public abstract class BenchmarkBase<TSerializer, TModel>
        where TSerializer : SerializerBase, new() where TModel : class
    {
        private readonly List<TModel> _hundred;
        private readonly TModel _single;
        private readonly TSerializer _serializer = new TSerializer();
        private readonly List<TModel> _ten;
        private readonly List<TModel> _thousand;

        public BenchmarkBase()
        {
            var fixture = new ExpressionTreeFixture();
            _single = fixture.Create<TModel>();
            _ten = fixture.CreateMany<TModel>(10).ToList();
            _hundred = fixture.CreateMany<TModel>(100).ToList();
            _thousand = fixture.CreateMany<TModel>(1000).ToList();
        }

        
        [Benchmark]
        public object SerializeSingle()
        {
            return _serializer.Serialize(_single);
        }


        [Benchmark]
        public object SerializeTen()
        {
            return _serializer.Serialize(_ten);
        }

        [Benchmark]
        public object SerializeHundred()
        {
            return _serializer.Serialize(_hundred);
        }


        [Benchmark]
        public object SerializeThousand()
        {
            return _serializer.Serialize(_thousand);
        }
    }
}