using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancess
{
    class Program
    {
        static void Main(string[] args)
        {
            Players ply = new Players();
            Coach coach = new Coach();
            Person person = new Person();

            //her bir class ayrı ayrı implemente edilebilir.
            //her bir class sadce bir kere miras alabilir.
            //interfaceler birden fazla olabilir ancak miras işlemi birkere tanımlanır
        }
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }
        class Players : Person
        {
            public string Position { get; set; }
        }
        class Coach:Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }
    }
}
