using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            sql sql = new sql();
            sql.Add();
            sql.Deleted();
            mySql mySql = new mySql();
            mySql.Add();
            mySql.Deleted();
            Console.ReadLine();
        }
    }
    class database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Deleted()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class sql : database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }
    class mySql : database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by mySql Code");
        }
    }
}
