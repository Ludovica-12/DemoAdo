using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf.Entites
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public GenderEnum Gender { get; set; }
        public bool Member { get; set; }
        public int? Id { get; set; }

        public User()
        {

        }
        public User(string firstName, string lastName, DateTime date, GenderEnum gender, bool member, int? id)
        {
            FirstName = firstName;
            LastName = lastName;
            Date = date;
            Gender = gender;
            Member = member;
            Id = id;
        }

        public void Print()
        {
            Console.WriteLine($"Nome: {FirstName} Cognome: {LastName} Data di Nascita {Date} Sesso: {Gender} Tesserato: {Member}") ;
        }

    }
     public enum GenderEnum
    {
        Male = 1,
        Female = 2
    }
}
