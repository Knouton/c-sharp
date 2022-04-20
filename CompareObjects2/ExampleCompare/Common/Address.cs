namespace ExampleCompare.Common
{
    public class Address
    {
        public int id { get; set; }
        public string name { get; set; }

        public Address(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
