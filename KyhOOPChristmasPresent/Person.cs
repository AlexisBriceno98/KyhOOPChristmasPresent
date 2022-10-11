using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhOOPChristmasPresent
{
    public class Person
    {
        private readonly string _name;
        private List<ChristmasPresent> presentList = new();

        public void AddPresent(ChristmasPresent present)
        {
            presentList.Add(present);
        }
        public Person(string name)
        {
            _name = name;
        }
    }
}
