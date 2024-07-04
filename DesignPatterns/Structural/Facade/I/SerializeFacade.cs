using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Facade.I
{
    internal class SerializeFacade
    {
        private static readonly JsonSerializerOptions _settings = new JsonSerializerOptions()
        {
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
            IgnoreReadOnlyProperties = true,
            ReferenceHandler = ReferenceHandler.Preserve,
        };

        public static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize(obj, _settings);
        }
    }
}
