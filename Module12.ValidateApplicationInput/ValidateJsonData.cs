using Module12.ValidateApplicationInput;
using Nancy.Json;
using Newtonsoft.Json;
using System;

namespace Module12.ValidateApplicationInput
{
    public static class ValidateJsonData
    {
        public static void GetExample()
        {
            const string studentJson = "{\"name\": \"luis\", \"age\": 27 }";
            const string invalidStudentJson = "\"name\": \"luis\", \"age123\": 27";

            // Using JavaScriptSerializer
            var javascriptSerializer = new JavaScriptSerializer();

            try
            {
                var studentUsingJavascriptSerializer = javascriptSerializer.Deserialize<Student>(studentJson);
                var invalidStudentUsingJavaScriptSerializer = javascriptSerializer.Deserialize<Student>(invalidStudentJson);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentException for JavaScriptSerializer, invalidStudentJson!");
            }

            // Using Newtonsoft.Json
            try
            {
                var studentUsingNewtonsoft = JsonConvert.DeserializeObject<Student>(studentJson);
                var invalidStudentUsingNewtonsoft = JsonConvert.DeserializeObject<Student>(invalidStudentJson);

            }
            catch (JsonSerializationException)
            {
                Console.WriteLine("JsonSerializationException for Newtonsoft.Json, invalidStudentJson");
            }

            Console.ReadLine();
        }
    }
}
