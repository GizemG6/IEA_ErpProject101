using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            //solid prensiblerinden 4.olan interface segragation prendibini kullandik.
            //single responsibilty:siniflarin iyi tanimlanmis tek sorumlulugu olmali
            //open-close:siniflar degisiklige kapali ancak yeni davranis eklemeye acik
            //liskov substitution:kodda herhangi bi degisiklik yapmaya gerek kalmadan turetilmis siniflarin yani subclasslarin turedikleri ata sinifin(base class)yerine kullanabilmeliyiz
            //interface segragation:genel kullanim amacli tek bir kontrat yerine daha özellesmis birden cok kontrat olusturmayi tercih etmeliyiz
            //dependency inversion:katmanli mimarilerde ust seviye moduller alt seviyedeki modullere dogrudan bagimli olmamalidir
        }
    }
    interface IWorker
    {
        void Work();
       
        
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
