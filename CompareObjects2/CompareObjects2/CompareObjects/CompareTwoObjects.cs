using Reinforced.Typings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;

namespace CompareObjects2.CompareObjects
{
    public static class CompareTwoObjects
    {
        //полное сравнение двух объектов: сранивает что объекты одного типа, что кол-во полей в них одинаковое
        //затем сравнивает по значениям полей,
        //возвращает Dictionary<название поля которое не совпадают у двух классов, массив из двух значений: значение у 1 объекта, значение у 2 объекта> 
        public static object[] CompareObjects(object objectX, object objectY)
        {
            var objectXType = objectX.GetType();
            var objectYType = objectY.GetType();

            object[] arrResult = new object[2];

            // Строки
                if (Type.GetTypeCode(objectXType) == TypeCode.String
                    || Type.GetTypeCode(objectYType) == TypeCode.String)
                {
                    if (!objectX.Equals(objectY))
                    {
                        arrResult =  new object[] { objectX, objectY };
                    }
                }
                //примитивы или перечисления
                else if (objectXType.IsPrimitive
                    || objectYType.IsPrimitive)
                {
                    if (!objectX.Equals(objectY))
                    {
                        arrResult = new object[] { objectX, objectY };
                    }
                }
                // Коллекции
                else if (objectXType.IsImplementIEnumerable()
                         || objectYType.IsImplementIEnumerable())
                {
                    if (objectX.GetHashCode() != objectY.GetHashCode())
                    {
                    var res = new object[] { CompareEnumerables(objectX, objectY), CompareEnumerables(objectY, objectX) };
                    if (res.Length > 0) arrResult = res;
                    }
                } 
                else if ((objectXType.IsClass || objectXType.IsInterface) ||
                         (objectYType.IsClass || objectYType.IsInterface))
                {
                    var fieldValues = ObjectToDictionaryFieldValue(objectX);
                    var fieldValues2 = ObjectToDictionaryFieldValue(objectY);
                    var res = new object[] {CompareValueObjects(fieldValues, fieldValues2)};
                    if (res.Length >0) arrResult  = res;
                }
                else
                {
                    if (!objectX.Equals(objectY))
                    {
                        arrResult = new object[] { objectX, objectY };
                    }
                }
                return arrResult;
        }

        public static bool IsImplementIEnumerable(this Type type) => type.GetInterface("IEnumerable`1") != null;


        private static Dictionary<string, object[]> CompareValueObjects(Dictionary<string, object> fieldValues, Dictionary<string, object> fieldValues2)
        {
            Dictionary<string, object[]> differentKeyValuePairs = new Dictionary<string, object[]>();
            object[] arrCompareObjects = new object[2];
            foreach (var keyValue in fieldValues)
            {
                if (!fieldValues2.ContainsKey(keyValue.Key))
                {
                    differentKeyValuePairs.Add(keyValue.Key, new object[] { keyValue.Value, null });
                }
                else
                {
                    var keyValue1 = keyValue.Value == null ? 0 : keyValue.Value.GetHashCode();
                    var keyValue2 = fieldValues2[keyValue.Key] == null ? 0 : fieldValues2[keyValue.Key].GetHashCode();

                    if (keyValue1.GetHashCode() != keyValue2.GetHashCode()
                        && keyValue.Value != null
                        && fieldValues2[keyValue.Key] != null)
                    {
                        arrCompareObjects = CompareObjects(keyValue.Value, fieldValues2[keyValue.Key]);
                        if (arrCompareObjects != null && arrCompareObjects.Length != 0)
                            differentKeyValuePairs.Add(keyValue.Key, arrCompareObjects);
                    }
                }
            }

            foreach (var keyValue in fieldValues2)
            {
                if (!differentKeyValuePairs.ContainsKey(keyValue.Key) && !fieldValues.ContainsKey(keyValue.Key))
                {
                    differentKeyValuePairs.Add(keyValue.Key, new object[] { null, keyValue.Value });
                }
            }
            return differentKeyValuePairs;
        }

        public static IEnumerable CompareEnumerables (object objectX, object objectY)
        {
           
            
            Type enumerableInterface = objectX.GetType().GetInterface("IEnumerable`1");
            Type elementType = typeof(object);
            if (enumerableInterface != null) elementType = enumerableInterface.GetGenericArguments()[0];
            List<object> resultList = new List<object>();

            if (elementType.IsPrimitive || Type.GetTypeCode(elementType) == TypeCode.String)
            {
                var collection = objectX as ICollection;
                var collection2 = objectY as ICollection;
                return collection.OfType<object>()
                    .Except(collection2.OfType<object>());
            }
            else
            {
                var collectionX =objectX as IEnumerable<object>;
                var collectionY = objectY as IEnumerable<object>;
                int collectXCount = 0;
                int collectYCount = 0;
                if (!(collectionX is null)) collectXCount = collectionX.Count();
                if (!(collectionY is null)) collectYCount = collectionY.Count();
                 
                List<object> returnList = new List<object>();
                for (int i = 0; i < Math.Max(collectXCount, collectYCount); i++)
                {
                    returnList.Add( CompareObjects(i < collectXCount ? collectionX.ElementAt(i) : new object()
                        ,i < collectYCount ? collectionY.ElementAt(i) : new object()));
                }

                return returnList;
            }
        }
        // сравнивает одинаковый ли тип у двух объектов
        public static Boolean CompareTypeObjects(object object1, object object2)
        {
            return object1.GetType() == object2.GetType();
        }

        //сравнить два объекта по значению их полей, возвращает
        //Dictionary<название поля которое не совпадают у двух классов, массив из двух значений: значение  объекта, значение 2 объекта>
        public static Dictionary<string, object[]> CompareValueObjects(object object1, object object2)
        {

            var fieldValues = ObjectToDictionaryFieldValue(object1);
            var fieldValues2 = ObjectToDictionaryFieldValue(object2);

            return CompareValueObjects(fieldValues, fieldValues2);
        }

        // сравнивает типы полей у двух объектов возвращает
        //Dictionary<название поля которое не совпадают у двух классов, у какого класса это поле>
        private static Dictionary<string, object[]> CompareFieldTypeObjects(Dictionary<string, object> fieldValues, Dictionary<string, object> fieldValues2)
        {
            Dictionary<string, object[]> differentKeyObjectPairs = new Dictionary<string, object[]>();

            foreach (var keyValue in fieldValues)
            {
                if (!fieldValues2.ContainsKey(keyValue.Key))
                {
                    differentKeyObjectPairs.Add("Object1 field: " + keyValue.Key, new object[] { keyValue.Value.GetType().ToString() });
                }
            }
            foreach (var keyValue in fieldValues2)
            {
                if (!fieldValues.ContainsKey(keyValue.Key))
                {
                    differentKeyObjectPairs.Add("Object2 field: " + keyValue.Key, new object[] { keyValue.Value.GetType().ToString() });
                }
            }
            return differentKeyObjectPairs;
        }


        //преобразовать объект в словарь Dictionary<имя поля, object> 
        public static Dictionary<string, object> ObjectToDictionaryFieldValue(object object1)
        {
            return object1.GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public |
                               BindingFlags.Static)
                .ToDictionary(field => field.Name, field => field.GetValue(object1));
        }
    }
}
