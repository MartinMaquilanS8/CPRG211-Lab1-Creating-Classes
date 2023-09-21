using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Relation
    {
        private string person1Relation;
        private Person person1;

        private Person person2;

        public string Person1Relation { get { return person1Relation; } }
        public Person Person1 { get { return person1; } }
        public Person Person2 { get { return person2; } }

        public Relation(string person1Relation, Person person1, Person person2)
        {
            this.person1Relation = person1Relation;
            this.person1 = person1;
            this.person2 = person2;
        }

        public override string ToString()
        {
            string formatted;

            formatted = $"Relationship between {Person1.FirstName} and {Person2.FirstName} is: {person1Relation}\n";

            return formatted;
        }
    }
}
