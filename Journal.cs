using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_29._04
{
    public class Journal
    {
        public string Name = "";
        public int Year = 0;
        public string Description = "";
        public string Number = "";
        public string Email = "";

        public Journal(string name, int year, string description, string number, string email)
        {
            Name = name;
            Year = year;
            Description = description;
            Number = number;
            Email = email;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}\nYear: {Year}\nDescription: {Description}\nNumber: {Number}\nEmail: {Email}");
        }

        public void SetName(string name) { Name = name; }
        public void SetYear(int year) { Year = year; }
        public void SetDescription(string description) { Description = description; }
        public void SetNumber(string number) { Number = number; }
        public void SetEmail(string email) { Email = email; }

        public string GetName() { return Name; }
        public int GetYear() { return Year; }
        public string GetDescription() { return Description; }
        public string GetNumber() { return Number; }
        public string GetEmail() { return Email; }

    }
}
