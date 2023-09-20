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
        private string firstname;
        private string lastname;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        public int Id { get { return id; } set {  id = value; } }

        // public int Id { get => id; set => id = value; }

        public string Firstname { get {  return firstname; } set {  firstname = value; } }

        // public string FirstName { get => firstName; set => firstName = value; }


        public string Lastname { get { return lastname; } set {  lastname = value; } }

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


        public Person(int id, string firstname, string lastname, string favoriteColour, int age, bool isWorking)
        {
           Id = id;
           Firstname = firstname; 
           Lastname = lastname;
           //this.id = id;
           //this.firstname = firstname;
           //this.lastname = lastname;   
           FavoriteColour = favoriteColour;
           Age = age;
           IsWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {
            string formatted = "";

            formatted = $"{id}:, {firstname}, {lastname}'s facorite colour is, {favoriteColour}\n";


            return formatted;

        }

        public void ChangeFavoriteColour()
        {
            favoriteColour = "white";
        }

    }
}
