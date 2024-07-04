using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Facade.I
{
    internal class Client
    {
        public static void Execute()
        {
            var person = new Person { FirstName = "Ewa", LastName = "Ewowska", BirthDate = DateTime.Now.AddYears(-32) };

            /*var settings = new JsonSerializerOptions()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
                IgnoreReadOnlyProperties = true,
                ReferenceHandler = ReferenceHandler.Preserve,
            };

            var json = JsonSerializer.Serialize(person, settings);*/

            var json = SerializeFacade.Serialize(person);

            Console.WriteLine(json);
        }
    }
}
