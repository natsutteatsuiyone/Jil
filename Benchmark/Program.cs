using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using Benchmark.Serializers;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //BuildTypes();

            var types = typeof(JilSerializerAndAccessToken).Assembly.GetTypes();
            foreach (var type in types)
            {

                BenchmarkRunner.Run(type);
            }
        }

        private static void BuildTypes()
        {
            var asmName = new AssemblyName
            {
                Name = "BenchmarkTypes"
            };
            var asmBuild = Thread.GetDomain().DefineDynamicAssembly(asmName, AssemblyBuilderAccess.RunAndSave);
            var modBuild = asmBuild.DefineDynamicModule("ModuleOne", "BenchmarkTypes.dll");
            var serializers = GetAllSerializers();
            var models = GetAllModels();
            foreach (var serializer in serializers)
            {
                foreach (var model in models)
                {
                    TypeBuilder typeBuild = modBuild.DefineType($"{serializer.Name}And{model.Name}",
                        TypeAttributes.Public, typeof(BenchmarkBase<,>).MakeGenericType(serializer, model));
                    typeBuild.CreateType();
                }
            }
            asmBuild.Save("BenchmarkTypes.dll");
        }

        private static List<Type> GetAllSerializers()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => !t.IsAbstract && typeof(SerializerBase).IsAssignableFrom(t))
                .ToList();
        }

        private static List<Type> GetAllModels()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.Namespace == "Benchmark.Models" && !t.IsEnum && !t.IsInterface && !t.IsAbstract)
                .ToList();
        }
    }
}