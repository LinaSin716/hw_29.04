using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_29._04
{
    public class Shop
    {
        public string Name = "";
        public string Address = "";
        public string Description = "";
        public string Number = "";
        public string Email = "";

        public Shop(string name, string address, string description, string number, string email)
        {
            Name = name;
            Address = address;
            Description = description;
            Number = number;
            Email = email;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}\nAddress: {Address}\nDescription: {Description}\nNumber: {Number}\nEmail: {Email}");
        }

        public void SetName(string name) { Name = name; }
        public void SetAddress(string address) { Address = address; }
        public void SetDescription(string description) { Description = description; }
        public void SetNumber(string number) { Number = number; }
        public void SetEmail(string email) { Email = email; }

        public string GetName() { return Name; }
        public string GetAddress() { return Address; }
        public string GetDescription() { return Description; }
        public string GetNumber() { return Number; }
        public string GetEmail() { return Email; }
    }
}
