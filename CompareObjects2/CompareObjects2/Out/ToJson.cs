using CompareObjects2.Out.Interfaces;
using System.Collections.Generic;
using System.Text.Json;

namespace CompareObjects2.Out
{
    public class ToJson : IOut
    {
        public static string DictionaryStingObject(Dictionary<string, object> keyValuePairs)
        {
            return JsonSerializer.Serialize(keyValuePairs);
        }

        public static string ArrObjectsToJsonString( object[] valuePairs)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(valuePairs);
        }

    }
}
