using ExampleCompare.Common;
using System;
using System.Collections.Generic;

namespace ExampleCompare
{
    public class ObjectExample2
    {
        public int parA { get; set; }
        public string parB { get; set; }
        public double parC { get; set; }
        public DateTime parD { get; set; }
        public Decimal parE { get; set; }
        public float parF { get; set; }
        public int parH { get; set; }
        public Address adress { get; set; }
        public List<Address> adressList { get; set; } = new List<Address>();
        public List<List<Address>> adressListLists { get; set; } = new List<List<Address>>();
        public List<int> intList { get; set; } = new List<int>();

        public ObjectExample2(int parA, string parB, double parC, DateTime parD, Decimal parE, float parF, int parH, Address addres, List<Address> adressList, List<List<Address>> adressListLists, List<int> intList)
        {
            this.parA = parA;
            this.parB = parB;
            this.parC = parC;
            this.parD = parD;
            this.parE = parE;
            this.parF = parF;
            this.parH = parH;
            this.adress = addres;
            this.adressList = adressList;
            this.intList = intList;
            this.adressListLists = adressListLists;
        }
    }
}
