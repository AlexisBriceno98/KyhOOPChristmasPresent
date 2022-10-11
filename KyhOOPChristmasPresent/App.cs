using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhOOPChristmasPresent
{
    public class App
    {
        public void Run()
        {
            var person1 = new Person("Stefan");
            var person2 = new Person("Kerstin");

            person1.AddPresent(new ChristmasPresent("PS5", 4800));
            person1.AddPresent(new ChristmasPresent("Mobil", 1300));
            person2.AddPresent(new ChristmasPresent("Dator", 15000));

            var personList = new List<Person>();
            personList.Add(person1);
            personList.Add(person2);

            foreach(var person in personList)
            {
                Console.WriteLine($"{person.name} ska få julklappar för {person.GetTolalPrice()}kr ");
            }


        }
    }
}
