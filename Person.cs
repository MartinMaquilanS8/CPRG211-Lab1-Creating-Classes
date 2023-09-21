using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        public int Id { get { return id; } set {  id = value; } }

        // public int Id { get => id; set => id = value; }

        public string FirstName { get {  return firstName; } set {  firstName = value; } }

        // public string FirstName { get => firstName; set => firstName = value; }


        public string LastName { get { return lastName; } set {  lastName = value; } }

        // public string LastName { get => lastName; set => lastName = value; }


        public string FavoriteColour { get {  return favoriteColour; } set {  favoriteColour = value; } }

        // public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }


        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 122)
                {
                    age = value;
                }
            }
        }
        public bool IsWorking { get {  return isWorking; } set {  isWorking = value; } }

        // public bool IsWorking { get => isWorking; set => isWorking = value; }


        public Person(int id, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
           this.id = id;
           this.firstName = firstName;
           this.lastName = lastName;   
           FavoriteColour = favoriteColour;
           Age = age;
           IsWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {
            //string formatted = "";

            //formatted = $"{id}:, {firstname}, {lastname}'s favorite colour is, {favoriteColour}\n";

            //return formatted;

            return $"{id}: {firstName} {lastName}'s favorite colour is: {favoriteColour}\n";
        }

        public void ChangeFavoriteColour()
        {
            favoriteColour = "white";
        }

        public int GetAgeInTenYears()
        {
            int ageInTenYears = age + 10;

            return ageInTenYears;
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += $"PersonID: {id}\n";
            formatted += $"FirstName: {firstName}\n";
            formatted += $"LastName: {lastName}\n";
            formatted += $"FavoriteColour: {favoriteColour}\n";
            formatted += $"Age: {age}\n";
            formatted += $"IsWorking: {isWorking}\n";

            return formatted;
        }
    }
}
