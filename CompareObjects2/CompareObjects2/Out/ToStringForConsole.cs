using CompareObjects2.Out.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace CompareObjects2.Out
{
    public class ToStringForConsole : IOut
    {

        public static string DictionaryStingObject(Dictionary<string, object> keyValuePairs)
        {
            StringBuilder resultStringBuilder = new StringBuilder();
            foreach (var pair in keyValuePairs)
            {
                resultStringBuilder.Append("Поле:")
                    .Append(pair.Key)
                    .Append(" Значение: ")
                    .Append(pair.Value)
                    .Append("\n");
            }

            return resultStringBuilder.ToString();
        }
        public static string DictionaryStingArrObject(Dictionary<string, object[]> keyValuePairs)
        {
            StringBuilder resultStringBuilder = new StringBuilder();
            foreach (var pair in keyValuePairs)
            {
                resultStringBuilder.Append("Поле:")
                    .Append(pair.Key)
                    .Append(" Значение первого объекта: ")
                    .Append(pair.Value[0])
                    .Append(" Значение второго объекта: ")
                    .Append(pair.Value[1])
                    .Append("\n");
            }

            return resultStringBuilder.ToString();
        }
    }
}
