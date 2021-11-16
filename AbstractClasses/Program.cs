using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            database database = new MsSql();
            database.Add();
            database.Deleted();
            database database2 = new Oracle();
            database2.Add();
            database2.Deleted();
            Console.ReadLine();

        }
    }
    abstract class database
    {   //abstract classlar ile hem tamamlanmis hem de tamamlanmamis metodlar tanimlayabiliriz.
        //abstract classlar birer inheritancetir bu yuzden her class icin birkez kullanilir sonrasinda interfacler varsa eklenebilir
        //abstract classlar new keywordu alamaz
        public void Add()//tamamlanmış metod
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Deleted();//tamamlanmamis metod
    }
    class MsSql : database
    {   //abstract dedigimiz sey ici dolu olmayan virtual metoddur.
        public override void Deleted()
        {
            Console.WriteLine("Deleted by MsSql");
        }
    }
    class Oracle : database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
