using CompareObjects2.CompareObjects;
using CompareObjects2.Out;
using ExampleCompare.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using Burgundy.Project.Models.ProjectEntity;
using MongoDB.Bson;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ExampleCompare
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            string path = @"E:\Projects\CompareObjects2\ExampleCompare\jsonExample1.json";
            string path2 = @"E:\Projects\CompareObjects2\ExampleCompare\jsonExample2.json";
            string path3 = @"E:\Projects\CompareObjects2\ExampleCompare\jsonExample3.json";
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            string jsonString = System.IO.File.ReadAllText(path, Encoding.Default);
            string jsonString2 = System.IO.File.ReadAllText(path2, Encoding.Default);
            string jsonString3 = System.IO.File.ReadAllText(path3, Encoding.Default);
            Project project = JsonConvert.DeserializeObject<Project>(jsonString);
            Project project2 =
                JsonSerializer.Deserialize<Project>(jsonString2, options);

            var timer = new Stopwatch();
            timer.Start();
            var json = ToJson.ArrObjectsToJsonString(CompareTwoObjects.CompareObjects(project2, project));
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            Console.WriteLine(json);
            Console.WriteLine(timeTaken.TotalMilliseconds);

            /*List<Address> listAddress1 = new List<Address>();
            listAddress1.Add(new Address(10, "listAress1"));
            listAddress1.Add(new Address(11, "listAress11"));
            List<Address> listAddress2 = new List<Address>();
            listAddress2.Add(new Address(20, "listAress2"));

            List<Address> listAddress3 = new List<Address>();
            listAddress3.Add(new Address(30, "listAress3"));
            List<Address> listAddress4 = new List<Address>();
            listAddress4.Add(new Address(40, "listAress4"));

            List<List<Address>> listListsAddress1 = new List<List<Address>>();
            listListsAddress1.Add(listAddress1);
            listListsAddress1.Add(listAddress2);

            List<List<Address>> listListsAddress2 = new List<List<Address>>();
            listListsAddress1.Add(listAddress3);
            listListsAddress1.Add(listAddress4);

            List<int> intList1 = new List<int>();
            intList1.Add(1);
            intList1.Add(3);

            List<int> intList2 = new List<int>();
            intList2.Add(10);
            intList2.Add(11);


            ObjectExample2 objectExample1 = new ObjectExample2(1, "test", 1.05, DateTime.Now, decimal.MaxValue, 1111111,
                10, new Address(1, "adress1"), listAddress1, listListsAddress1, intList1);
            ObjectExample2 objectExample2 = new ObjectExample2(2, "test2", 1.06, DateTime.Now, decimal.MinValue, 22222,
                20, new Address(2, "adress2"), listAddress4, listListsAddress2, intList2);
           

            foreach(var var in listListsAddress2)
            {
                Type enumerableInterface = var.GetType().GetInterface("IEnumerable`1");
                ;
                Type elementType = enumerableInterface.GetGenericArguments()[0];
            }


            var json1 = ToJson.ArrObjectsToJsonString(CompareTwoObjects.CompareObjects(objectExample1, objectExample2));
            Console.WriteLine(json1);*/
        }
    }
}
