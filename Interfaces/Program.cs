using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaceler hicbir zaman new keywprduyle kullanilamazlar
            //IPerson iper= new IPerson(); xxx
            //ancak IPerson interfaceinden urettigimiz siniflar newlenebilir
            NewMethod();
            //pm.Add(customer);
        }

        private static void NewMethod()
        {
            IPerson person = new Customer();

            Customer customer = new Customer
            {
                id = 1,
                Name = "Gizem",
                LastName = "Gunes",
                Adress = "Esengles"
            };
            PersonManager pm = new PersonManager();
        }
    }
    interface IPerson
    {
        //temel nesne olusturup diger nesneleri ondan implemente etmektir
        //soyut nesneler tek baslarina anlam ifade etmezler ve somut nesnelere ihtiyac duyarlar
        int id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        

    }
    class Customer : IPerson //somut nesne
    {
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string StudentNo { get; set; }
    }
    class PersonManager : IPerson
    {
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
