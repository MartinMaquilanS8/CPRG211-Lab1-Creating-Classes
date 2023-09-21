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

        //private string person2Relation;
        private Person person2;

        public string Person1Relation { get { return person1Relation; } }
        public Person Person1 { get { return person1; } }
        //public string Person2Relation { get { return person2Relation; } }
        public Person Person2 { get { return person2; } }

        //public Relation(string person1Relation, Person person1, string person2Relation, Person person2)
        public Relation(string person1Relation, Person person1, Person person2)
        {
            this.person1Relation = person1Relation;
            this.person1 = person1;
            //this.person2Relation = person2Relation;
            this.person2 = person2;
        }

        //public string ShowRelationShip()
        //{
        //return $"Relationship between {Person1.FirstName} and {Person2.FirstName} is: {Person1Relation} and {Person2Relation}";
        //}
        public override string ToString()
        {
            string formatted;

            formatted = $"Relationship between {Person1.FirstName} and {Person2.FirstName} is: {person1Relation}\n";
            //formatted += $"Relationship between {Person1.FirstName} and {Person2.FirstName} is: {person2Relation}\n";
            //formatted = Person1.FirstName + " is a " + Person1Relation + "\n";
            //formatted += Person2.FirstName + " is a " + Person2Relation + "\n";

            return formatted;
        }
    }
}
